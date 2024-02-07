using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.SE.Omapi;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

/* Summary I've done in register.xml -Jonard
        email                           - Set to email type
        first name, last name           - Set to string
        age                             - Set to integer
        gender                          - Radio buttons
        height, weight                  - Set to decimal
        bmi                             - Set to decimal, and edit text cannot be edited unless clicked the "Get BMI" 
                                          button to get the values from height and weight
        password, re-type password      - Set to password type
 */

namespace App1
{
    [Activity(Label = "Register")]
    public class Register : Activity
    {
        TextView txtemail;
        EditText email, firstname, lastname, age, height, weight, bmi, password, repassword;
        RadioGroup rd_gender;
        string selectedGender, valueGender;
        Button register, home, getbmi;
        Decimal bmivalue;
        DBClass db = new DBClass();
        JsonElement root;
        string searchemail;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.register);

            // Create your application here
            home = FindViewById<Button>(Resource.Id.btn_Home);
            home.Click += homeClick;

            txtemail = FindViewById<TextView>(Resource.Id.txtV_Email);
            

            email = FindViewById<EditText>(Resource.Id.edtTxt_Email);
            firstname = FindViewById<EditText>(Resource.Id.edtTxt_FirstName);
            lastname = FindViewById<EditText>(Resource.Id.edtTxt_LastName);
            age = FindViewById<EditText>(Resource.Id.edtTxt_Age);
            
            rd_gender = FindViewById<RadioGroup>(Resource.Id.rdGrp_gender);
            //rd_gender.Check(2131230885);
            rd_gender.CheckedChange += myRadioGroup_CheckedChange;
            
            height = FindViewById<EditText>(Resource.Id.edtTxt_Height);
            weight = FindViewById<EditText>(Resource.Id.edtTxt_Weight);
            bmi = FindViewById<EditText>(Resource.Id.edtTxt_BMI);

            getbmi = FindViewById<Button>(Resource.Id.btn_GetBMI);
            getbmi.Click += GetBMIClick;

            password = FindViewById<EditText>(Resource.Id.edtTxt_Password);
            repassword = FindViewById<EditText>(Resource.Id.edtTxt_RePassword);


            register = FindViewById<Button>(Resource.Id.btn_Register);
            register.Click += registerClick;

            txtemail.Text = selectedGender;

        }

        public void homeClick(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(MainActivity));
            StartActivity(i);
        }

        public void myRadioGroup_CheckedChange(object sender, RadioGroup.CheckedChangeEventArgs e)
        {
            int checkedItemId = rd_gender.CheckedRadioButtonId;
            RadioButton checkRadioButton = FindViewById<RadioButton>(checkedItemId);
            selectedGender = checkedItemId.ToString();
            rd_gender.Check(checkedItemId);
        }

        // Calculate BMI from the user inputs height and weight
        public void GetBMIClick(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(height.Text) <= 0 || Convert.ToDecimal(weight.Text) <= 0)
                { Toast.MakeText(this, "Invalid Height and Weight!", ToastLength.Long).Show(); }
                else
                {
                    bmivalue = Convert.ToDecimal(weight.Text) / Convert.ToDecimal(Math.Pow(Convert.ToDouble(height.Text), 2));
                    bmivalue = Math.Round(bmivalue, 2);
                    bmi.Text = Convert.ToString(bmivalue);
                }
            }
            catch { Toast.MakeText(this, "Invalid Height and Weight!", ToastLength.Long).Show(); }
        }

        public void registerClick(object sender, EventArgs e)
        {
            if (Validation() && NoDuplicate() && (password.Text == repassword.Text))
            {
                valueGender = getGender();
                db.InsertData("insert_account.php?email=" + email.Text + "&first_name=" + firstname.Text + "&last_name=" + lastname.Text + "&age=" + age.Text + "&gender=" + valueGender+
                                                "&height=" + height.Text + "&weight=" + weight.Text + "&bmi=" + bmi.Text + "&password=" + password.Text);

                Toast.MakeText(this, "Successfully create account!", ToastLength.Long).Show();
                Intent i = new Intent(this, typeof(MainActivity));
                StartActivity(i);

            }
            else if (!NoDuplicate()) { Toast.MakeText(this, "Account Already Exists!", ToastLength.Long).Show(); }
            else { Toast.MakeText(this, "Unable to Register!", ToastLength.Long).Show(); }
        }

        //Validation - need to revise cause this is not the best conditions to use but still works tho -Jonard
        public bool Validation()
        {
            if (email.Text == "" || firstname.Text == "" || lastname.Text == "" || age.Text == "" ||
                password.Text == "" || repassword.Text == "" || selectedGender == null)
            { return false; }
            try
            {
                if (Convert.ToDecimal(height.Text) <= 0 || Convert.ToDecimal(weight.Text) <= 0 || Convert.ToDecimal(bmi.Text) <= 0 ||
                    Convert.ToDecimal(age.Text) <= 0)
                { return false; }
            }
            catch { return false; }
            return true;
        }
        //Validation - checks if the email already exists or not
        public bool NoDuplicate()
        {
            root = db.RetrieveData("search_noduplicate_acct.php?");
            for (int i = 0; i < root.GetArrayLength(); i ++)
            {
                var u1 = root[i];
                searchemail = u1.GetProperty("email").ToString();

                if (searchemail == email.Text)
                { return false; }
            }
            return true;
        }
        // Get Gender
        /* Radio button value
         * Male     - 2131230907
         * Female   - 2131230906
         */
        public string getGender()
        {
            if (selectedGender == "2131230907") { valueGender = "M"; }
            else if (selectedGender == "2131230906") { valueGender = "F"; }
            else { valueGender = null; }
            return valueGender;
        }
    }
}

