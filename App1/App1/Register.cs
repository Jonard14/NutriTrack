using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.SE.Omapi;
using Android.Text;
using Android.Views;
using Android.Widget;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace App1
{
    [Activity(Label = "Register", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Register : Activity
    {
        TextView txtemail, txtfirstname, txtlastname, txtage, txtheight, txtweight, txtpassword, txtrepassword;
        string required;
        EditText email, firstname, lastname, height, weight, bmi, password, repassword;
        Spinner gender, illness;
        CheckBox ill_HD, ill_D, ill_C;
        string selected_gender, valueGender, selected_illness, success, success2, success3, success4;
        Button register, home, getbmi;
        Decimal bmivalue;
        DBClass db = new DBClass();
        JsonElement root;
        string searchemail;

        // Birthday
        private Spinner bmonth, bday, byear;
        private string set_bday, selected_bmonth, selected_bday, selected_byear, birthday_format;
        private ArrayAdapter _adapter_day, _adapter_year;
        private ArrayList array_day, array_year;

        int val;

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
            txtemail = FindViewById<TextView>(Resource.Id.txtV_Email);

            bmonth = FindViewById<Spinner>(Resource.Id.spinner_birthmonth);
            selected_bmonth = bmonth.SelectedItem.ToString();
            bmonth.ItemSelected += Bmonth_ItemSelected;
            bday = FindViewById<Spinner>(Resource.Id.spinner_birthday);
            load_days();
            selected_bday = bday.SelectedItem.ToString();
            bday.ItemSelected += Bday_ItemSelected;
            byear = FindViewById<Spinner>(Resource.Id.spinner_birthyear);
            load_years();
            selected_byear = byear.SelectedItem.ToString();
            byear.ItemSelected += Byear_ItemSelected;

            email = FindViewById<EditText>(Resource.Id.edtTxt_Email);
            email.TextChanged += Input_TextChanged;
            firstname = FindViewById<EditText>(Resource.Id.edtTxt_FirstName);
            firstname.TextChanged += Input_TextChanged;
            lastname = FindViewById<EditText>(Resource.Id.edtTxt_LastName);
            lastname.TextChanged += Input_TextChanged;

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

        // Return Home
        public void homeClick(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(MainActivity));
            StartActivity(i);
        }

        // Dynamically show error prompt in input field
        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            DynamicValidation();
        }
        private void DynamicValidation()
        {
            if (email.Text == "")
                email.Error = "Please enter your Email!";
            else if (isValidEmail(email.Text) == false)
                email.Error = "Email is not Valid!";
            if (firstname.Text == "")
                firstname.Error = "Please enter your Firstname!";
            else if (!(Regex.IsMatch(firstname.Text, @"^[\p{L}]+$")))
                firstname.Error = "Name must only contain letters!";
            if (lastname.Text == "")
                lastname.Error = "Please enter your Lastname!";
            else if (!(Regex.IsMatch(lastname.Text, @"^[\p{L}]+$")))
                lastname.Error = "Name must only contain letters!";

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

        
        // ===== Birthday Functions =====
        private void load_days() // Generate Drop down list of days based on Month
        {
            array_day = new ArrayList();

            if (selected_bmonth == "January" || selected_bmonth == "March" || selected_bmonth == "May" || selected_bmonth == "July" ||
                selected_bmonth == "August" || selected_bmonth == "October" || selected_bmonth == "December")
                for (int i = 1; i <= 31; i++)
                    array_day.Add(i.ToString());
            else if (selected_bmonth == "February")
                leap_year();
            else
                for (int i = 1; i <= 30; i++)
                    array_day.Add(i.ToString());

            _adapter_day = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, array_day);
            bday.Adapter = _adapter_day;

        }
        private void leap_year() // Checks for both month and year that are the month of February and year is divisible by 4
        {
            array_day = new ArrayList();

            if ((Int32.Parse(selected_byear) % 4) == 0)
                for (int i = 1; i <= 29; i++)
                    array_day.Add(i.ToString());
            else
                for (int i = 1; i <= 28; i++)
                    array_day.Add(i.ToString());
        }
        // Generates Drop down list of birth year from 1900 to a year before the present year
        private void load_years()
        {
            array_year = new ArrayList();

            for (int i = 1900; i < DateTime.Now.Year; i++)
                array_year.Add(i.ToString());

            _adapter_year = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, array_year);
            byear.Adapter = _adapter_year;
        }

        private void Bmonth_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        { 
            selected_bmonth = e.Parent.GetItemAtPosition(e.Position).ToString(); // Get value of Month
            set_bday = selected_bday; 
            load_days(); // Dynamic Drop down event to change list of days based on month selected
            bday.SetSelection(_adapter_day.GetPosition(set_bday)); // Retain the selected day after resetting the entire list of days
        }

        private void Bday_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            selected_bday = e.Parent.GetItemAtPosition(e.Position).ToString(); // Get value of Days
        }

        private void Byear_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            selected_byear = e.Parent.GetItemAtPosition(e.Position).ToString(); // Get value of Year

            // Same way as selecting month above, but also checks for month of February if the selected year is leap year
            if (selected_bmonth == "February")
            {
                set_bday = selected_bday;
                leap_year();
                _adapter_day = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, array_day);
                bday.Adapter = _adapter_day;
                bday.SetSelection(_adapter_day.GetPosition(set_bday)); // Retain the selected day after resetting the entire list of days
            }
        }
        private string Format_Date() // Birthday Format - converts to YYYY-MM-DD and save to DB
        {
            string month_format = "00", day = "00";
            switch (selected_bmonth)
            {
                case "January":
                    month_format = "01"; break;
                case "February":
                    month_format = "02"; break;
                case "March":
                    month_format = "03"; break;
                case "April":
                    month_format = "04"; break;
                case "May":
                    month_format = "05"; break;
                case "June":
                    month_format = "06"; break;
                case "July":
                    month_format = "07"; break;
                case "August":
                    month_format = "08"; break;
                case "September":
                    month_format = "09"; break;
                case "October":
                    month_format = "10"; break;
                case "November":
                    month_format = "11"; break;
                case "December":
                    month_format = "12"; break;
            }
            if (Int32.Parse(selected_bday) <= 9)
                day = "0" + selected_bday;
            else
                day = selected_bday;
            return selected_byear + "-" + month_format + "-" + day;
        }
        // ===== Birthday Functions Ends Here=====

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
            birthday_format = Format_Date(); // Convert birthday format to YYYY-MM-DD to save to DB

            if (Validation() && NoDuplicate())// && (password.Text == repassword.Text))
            {
                /*
                success = db.InsertData("insert_account.php?email=" + email.Text + "&first_name=" + firstname.Text + "&last_name=" + lastname.Text + "&birthday=" + birthday_format+ "&gender=" + valueGender +
                                                "&height=" + height.Text + "&weight=" + weight.Text + "&bmi=" + bmi.Text + "&password=" + password.Text);
                */
                success2 = db.InsertDataAzure("INSERT INTO user_data (email, first_name, last_name, birthday, gender, height, weight, bmi) " +
                    "VALUES ('"+ email.Text +"', '"+ firstname.Text +"', '"+ lastname.Text +"', " +
                    "'"+ birthday_format + "', '"+ valueGender + "', '"+ height.Text + "', '"+ weight.Text +"', '"+ bmi.Text +"')", 
                    "user_db");

                success3 = db.InsertDataAzure("UPDATE user_data SET " +
                    "daily_calorie_intake='0', total_calorie_intake='0', calorie_intake_days='0' " +
                    "WHERE email='"+ email.Text +"'", 
                    "user_db");

                success4 = db.InsertDataAzure("INSERT INTO login VALUES " +
                    "('"+ email.Text + "', HASHBYTES('SHA2_256','" + password.Text +"'))", 
                    "user_db");

                SaveIllness();
                //Console.WriteLine(success);
                Console.WriteLine(success2);
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
            if (email.Text == "" || firstname.Text == "" || !(Regex.IsMatch(firstname.Text, @"^[\p{L}]+$")) ||
                lastname.Text == "" || !(Regex.IsMatch(lastname.Text, @"^[\p{L}]+$")) ||
                height.Text == "" || height.Text == "0" || weight.Text == "" || weight.Text == "0" ||
                password.Text == "" || (password.Text).Length < 8 || repassword.Text == "" || password.Text != repassword.Text)
            {
                DynamicValidation();

                return false;
            }

            return true;
        }
        //Validation - checks if the email already exists or not
        public bool NoDuplicate()
        {
            //root = db.RetrieveData("search_noduplicate_acct.php?");
            root = db.RetrieveDataAzure("SELECT * FROM login",
                                        null, "user_db");
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
            /*
            if (ill_HD.Checked) { success = db.InsertData("insert_illness.php?email=" + email.Text + "&types=" + ill_HD.Text); }
            if (ill_D.Checked) { success = db.InsertData("insert_illness.php?email=" + email.Text + "&types=" + ill_D.Text); }
            if (ill_C.Checked) { success = db.InsertData("insert_illness.php?email=" + email.Text + "&types=" + ill_C.Text); }
            if (!ill_HD.Checked && !ill_D.Checked && !ill_C.Checked) { success = db.InsertData("insert_illness.php?email=" + email.Text + "&types=" + "Healthy"); }
            */
            /* Test/Debug
            Toast.MakeText(this, success, ToastLength.Long).Show();
            Console.WriteLine(success);
            Console.WriteLine(ill_HD.Text);
            Console.WriteLine(ill_D.Text);
            Console.WriteLine(ill_C.Text);
            Console.WriteLine(ill.Text);
            */

            if (ill_HD.Checked)
                success = db.InsertDataAzure("INSERT INTO illnesses VALUES ('"+ email.Text +"', '"+ ill_HD.Text + "')", "user_db");
            if (ill_D.Checked)
                success = db.InsertDataAzure("INSERT INTO illnesses VALUES ('" + email.Text + "', '" + ill_D.Text + "')", "user_db");
            if (ill_C.Checked)
                success = db.InsertDataAzure("INSERT INTO illnesses VALUES ('" + email.Text + "', '" + ill_C.Text + "')", "user_db");
            if (!ill_HD.Checked && !ill_D.Checked && !ill_C.Checked)
                success = db.InsertDataAzure("INSERT INTO illnesses VALUES ('" + email.Text + "', 'Healthy')", "user_db");
            Console.WriteLine(success);
        }
    }
}

