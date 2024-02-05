using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Summary I've done in register.xml -Jonard
        email                           - Set to email type
        first name, last name           - Set to string
        age                             - Set to integer
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
        EditText email, firstname, lastname, age, height, weight, bmi, password, repassword;
        Button register, home, getbmi;
        Decimal bmivalue;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.register);

            // Create your application here
            home = FindViewById<Button>(Resource.Id.btn_Home);
            home.Click += homeClick;

            email = FindViewById<EditText>(Resource.Id.edtTxt_Email);
            firstname = FindViewById<EditText>(Resource.Id.edtTxt_FirstName);
            lastname = FindViewById<EditText>(Resource.Id.edtTxt_LastName);
            age = FindViewById<EditText>(Resource.Id.edtTxt_Age);
            height = FindViewById<EditText>(Resource.Id.edtTxt_Height);
            weight = FindViewById<EditText>(Resource.Id.edtTxt_Weight);
            bmi = FindViewById<EditText>(Resource.Id.edtTxt_BMI);

            getbmi = FindViewById<Button>(Resource.Id.btn_GetBMI);
            getbmi.Click += GetBMIClick;

            password = FindViewById<EditText>(Resource.Id.edtTxt_Password);
            repassword = FindViewById<EditText>(Resource.Id.edtTxt_RePassword);


            register = FindViewById<Button>(Resource.Id.btn_Register);
            register.Click += registerClick;
        }

        public void homeClick(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(MainActivity));
            StartActivity(i);
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
            if (Validation() && (password.Text == repassword.Text))
            {
                Toast.MakeText(this, "Successfully create account!", ToastLength.Long).Show();
                insertUserData();
                insertLoginData();
                Intent i = new Intent(this, typeof(MainActivity));
                StartActivity(i);

            }
            else { Toast.MakeText(this, "Unable to Register!", ToastLength.Long).Show(); }
        }

        public void insertUserData() 
        {
            string res = "";
            DBClass db = new DBClass();

            res = db.InsertData("insert_record.php?email=" + email.Text + "&first_name" + firstname.Text + "&last_name" + lastname.Text + "&age" + Convert.ToInt32(age.Text) + "&height" + Convert.ToDecimal(height.Text) + "&weight" + Convert.ToDecimal(weight.Text) + "&bmi" + Convert.ToDecimal(bmi.Text));
            Toast.MakeText(Application.Context, String.Format(res), ToastLength.Short).Show();

        }

        public void insertLoginData()
        {
            string res = "";
            DBClass db = new DBClass();

            res = db.InsertLoginData("insert_login_record.php?email=" + email.Text + "&password" + password.Text);
            Toast.MakeText(Application.Context, String.Format(res), ToastLength.Short).Show();

        }

        //Validation - need to revise cause this is not the best conditions to use but still works tho -Jonard
        public bool Validation()
        {
            if (email.Text == "" || firstname.Text == "" || lastname.Text == "" || age.Text == "" ||
                password.Text == "" || repassword.Text == "")
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
    }
}

