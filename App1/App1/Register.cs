using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.SE.Omapi;
using Android.Text;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace App1
{
    [Activity(Label = "Register")]
    public class Register : Activity
    {
        EditText email, firstname, lastname, age, height, weight, bmi, password, repassword;
        Spinner gender, illness;
        CheckBox ill_HD, ill_D, ill_C;
        string selected_gender, valueGender, selected_illness, success;
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

            email = FindViewById<EditText>(Resource.Id.edtTxt_Email);
            email.TextChanged += Input_TextChanged;
            firstname = FindViewById<EditText>(Resource.Id.edtTxt_FirstName);
            firstname.TextChanged += Input_TextChanged;
            lastname = FindViewById<EditText>(Resource.Id.edtTxt_LastName);
            lastname.TextChanged += Input_TextChanged;
            age = FindViewById<EditText>(Resource.Id.edtTxt_Age);
            age.TextChanged += Input_TextChanged;

            gender = FindViewById<Spinner>(Resource.Id.spinner_gender);
            selected_gender = gender.SelectedItem.ToString();
            gender.ItemSelected += Gender_ItemSelected;

            height = FindViewById<EditText>(Resource.Id.edtTxt_Height);
            height.TextChanged += Input_TextChanged;
            weight = FindViewById<EditText>(Resource.Id.edtTxt_Weight);
            weight.TextChanged += Input_TextChanged;
            bmi = FindViewById<EditText>(Resource.Id.edtTxt_BMI);
            height.TextChanged += GetBMI;
            weight.TextChanged += GetBMI;

            //illness = FindViewById<Spinner>(Resource.Id.spinner_illness);
            selected_gender = gender.SelectedItem.ToString();
            gender.ItemSelected += Gender_ItemSelected;

            ill_HD = FindViewById<CheckBox>(Resource.Id.checkBox1);
            ill_D = FindViewById<CheckBox>(Resource.Id.checkBox2);
            ill_C = FindViewById<CheckBox>(Resource.Id.checkBox3);


            password = FindViewById<EditText>(Resource.Id.edtTxt_Password);
            password.TextChanged += Input_TextChanged;
            repassword = FindViewById<EditText>(Resource.Id.edtTxt_RePassword);
            repassword.TextChanged += Input_TextChanged;

            register = FindViewById<Button>(Resource.Id.btn_Register);
            register.Click += registerClick;
        }

        private void Weight_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }



        // Dynamically show error prompt in input field
        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (email.Text == "")
                email.Error = "Please enter your Email!";
            else if (isValidEmail(email.Text) == false)
                email.Error = "Email is not Valid!";
            if (firstname.Text == "")
                firstname.Error = "Please enter your Firstname!";
            if (lastname.Text == "")
                lastname.Error = "Please enter your Lastname!";
            if (lastname.Text == "")
                lastname.Error = "Please enter your Lastname!";

            if (age.Text == "")
                age.Error = "Please enter your Age!";
            else if (age.Text == "0")
                age.Error = "Age cannot have 0 value!";

            if (height.Text == "")
                height.Error = "Please enter your Weight!";
            else if (height.Text == "0")
                height.Error = "Height cannot have 0 value!";

            if (weight.Text == "")
                weight.Error = "Please enter your Height!";
            else if (weight.Text == "0")
                weight.Error = "Weight cannot have 0 value!";

            if (password.Text == "")
                password.Error = "Please enter your Password!";
            else if ((password.Text).Length < 8)
                password.Error = "Password must be minimum of 8 characters!";
            if (repassword.Text == "")
                repassword.Error = "Please re-type your Password!";
            else if (password.Text != repassword.Text)
                repassword.Error = "Passwords do not match!";

        }
        // Checks if Email format is valid
        public bool isValidEmail(string email)
        {
            return Android.Util.Patterns.EmailAddress.Matcher(email).Matches();
        }

        // Return Home
        public void homeClick(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(MainActivity));
            StartActivity(i);
        }

        // Get value of Gender Selected
        private void Gender_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            selected_gender = e.Parent.GetItemAtPosition(e.Position).ToString();

            // Convnert to single character to insert db
            if (selected_gender == "Male") { valueGender = "M"; }
            else if (selected_gender == "Female") { valueGender = "F"; }
        }

        // Calculate BMI from the user inputs height and weight
        private void GetBMI(object sender, EventArgs e)
        {
            try
            {
                bmivalue = Convert.ToDecimal(weight.Text) / Convert.ToDecimal(Math.Pow(Convert.ToDouble(height.Text), 2));
                bmivalue = Math.Round(bmivalue, 2);
                bmi.Text = Convert.ToString(bmivalue);
            }
            catch { bmi.Text = "0"; }
        }

        // Register Account
        public void registerClick(object sender, EventArgs e)
        {
            if (Validation() && NoDuplicate())// && (password.Text == repassword.Text))
            {
                success = db.InsertData("insert_account.php?email=" + email.Text + "&first_name=" + firstname.Text + "&last_name=" + lastname.Text + "&age=" + age.Text + "&gender=" + valueGender +
                                                "&height=" + height.Text + "&weight=" + weight.Text + "&bmi=" + bmi.Text + "&password=" + password.Text);
                SaveIllness();
                Console.WriteLine(success);
                //Toast.MakeText(this, success, ToastLength.Long).Show(); // Test/Debug

                Toast.MakeText(this, "Successfully create account!", ToastLength.Long).Show();
                Intent i = new Intent(this, typeof(Login));
                StartActivity(i);

            }
            else if (!NoDuplicate()) Toast.MakeText(this, "Account Already Exists!", ToastLength.Long).Show();
            else Toast.MakeText(this, "Unable to Register!", ToastLength.Long).Show();
        }

        //Validation
        public bool Validation()
        {
            if (email.Text == "" || firstname.Text == "" || lastname.Text == "" || age.Text == "" || age.Text == "0" ||
                height.Text == "" || height.Text == "0" || weight.Text == "" || weight.Text == "0" ||
                password.Text == "" || (password.Text).Length < 8 || repassword.Text == "" || password.Text != repassword.Text)
            {
                if (email.Text == "")
                    email.Error = "Please enter your Email!";
                else if (isValidEmail(email.Text) == false)
                    email.Error = "Email is not Valid!";
                if (firstname.Text == "")
                    firstname.Error = "Please enter your Firstname!";
                if (lastname.Text == "")
                    lastname.Error = "Please enter your Lastname!";
                if (lastname.Text == "")
                    lastname.Error = "Please enter your Lastname!";

                if (age.Text == "")
                    age.Error = "Please enter your Age!";
                else if (age.Text == "0")
                    age.Error = "Age cannot have 0 value!";

                if (height.Text == "")
                    height.Error = "Please enter your Weight!";
                else if (height.Text == "0")
                    height.Error = "Height cannot have 0 value!";

                if (weight.Text == "")
                    weight.Error = "Please enter your Height!";
                else if (weight.Text == "0")
                    weight.Error = "Weight cannot have 0 value!";

                if (password.Text == "")
                    password.Error = "Please enter your Password!";
                else if ((password.Text).Length < 8)
                    password.Error = "Password must be minimum of 8 characters!";
                if (repassword.Text == "")
                    repassword.Error = "Please re-type your Password!";
                else if (password.Text != repassword.Text)
                    repassword.Error = "Passwords do not match!";

                return false;
            }

            return true;
        }
        //Validation - checks if the email already exists or not
        public bool NoDuplicate()
        {
            root = db.RetrieveData("search_noduplicate_acct.php?");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];
                searchemail = u1.GetProperty("email").ToString();

                if (searchemail == email.Text)
                {
                    email.Error = "Account Already Exists!";
                    return false;
                }
            }
            return true;
        }

        // Insert Illness
        public void SaveIllness()
        {
            if (ill_HD.Checked) { success = db.InsertData("insert_illness.php?email=" + email.Text + "&types=" + ill_HD.Text); }
            if (ill_D.Checked) { success = db.InsertData("insert_illness.php?email=" + email.Text + "&types=" + ill_D.Text); }
            if (ill_C.Checked) { success = db.InsertData("insert_illness.php?email=" + email.Text + "&types=" + ill_C.Text); }
            if (!ill_HD.Checked && !ill_D.Checked && !ill_C.Checked) { success = db.InsertData("insert_illness.php?email=" + email.Text + "&types=" + "Healthy"); }
            /* Test/Debug
            Toast.MakeText(this, success, ToastLength.Long).Show();
            Console.WriteLine(success);
            Console.WriteLine(ill_HD.Text);
            Console.WriteLine(ill_D.Text);
            Console.WriteLine(ill_C.Text);
            Console.WriteLine(ill.Text);
            */
        }
    }
}

