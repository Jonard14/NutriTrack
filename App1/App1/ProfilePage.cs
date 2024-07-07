using Android.Animation;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.Graphics;
using Android.Hardware.Lights;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.Navigation;
using Google.Android.Material.Snackbar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using static Android.Provider.DocumentsContract;

namespace App1
{
    [Activity(Label = "Profile", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class ProfilePage : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DrawerNavigation selectedNav = new DrawerNavigation();
        DBClass db = new DBClass();
        JsonElement root;
        string email = Login.MyGlobals.Globalemail;
        string data_email, data_first_name, data_last_name, data_birthday, 
               data_height, data_weight, data_bmi, 
               data_gender;

        private TextView emailTxt, BMI_Classification, birthdayTxt, genderTxt, ageTxt;
        private EditText firstNameEditText, lastNameEditText,
                         height, weight, bmi, 
                         currentPassword, newPassword, rePassword;
        Decimal bmivalue;

        CheckBox ill_HD, ill_D, ill_C;
        string[] data_illness = new string[3];

        private Button updateProfile_Btn, updatePass_Btn;


        // Birthday
        private string[] split_bday;
        private string data_bmonth, data_bday, databyear;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.profile_page_drawer);
            
            // Drawer Layout
            AndroidX.AppCompat.Widget.Toolbar toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            //FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            //fab.Click += FabOnClick;

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

            // Create your application here
            // ---Profile Details---
            emailTxt = FindViewById<TextView>(Resource.Id.Txt_Email);

            firstNameEditText = FindViewById<EditText>(Resource.Id.edtTxt_FirstName);
            firstNameEditText.TextChanged += InputProfileText_TextChanged;
            lastNameEditText = FindViewById<EditText>(Resource.Id.edtTxt_LastName);
            lastNameEditText.TextChanged += InputProfileText_TextChanged;

            birthdayTxt = FindViewById<TextView>(Resource.Id.Txt_Birthday);
            ageTxt = FindViewById<TextView>(Resource.Id.age);
            genderTxt = FindViewById<TextView>(Resource.Id.Txt_Gender);

            height = FindViewById<EditText>(Resource.Id.edtTxt_Height);
            height.TextChanged += InputProfileNumber_TextChanged;
            weight = FindViewById<EditText>(Resource.Id.edtTxt_Weight);
            weight.TextChanged += InputProfileNumber_TextChanged;
            bmi = FindViewById<EditText>(Resource.Id.edtTxt_BMI);
            BMI_Classification = FindViewById<TextView>(Resource.Id.txtV_BMI_Classification);
            height.TextChanged += GetBMI;
            weight.TextChanged += GetBMI;

            ill_HD = FindViewById<CheckBox>(Resource.Id.checkBox1);
            ill_D = FindViewById<CheckBox>(Resource.Id.checkBox2);
            ill_C = FindViewById<CheckBox>(Resource.Id.checkBox3);

            // --- Change Password ---
            currentPassword = FindViewById<EditText>(Resource.Id.edtTxt_CurrentPassword);
            newPassword = FindViewById<EditText>(Resource.Id.edtTxt_NewPassword);
            rePassword = FindViewById<EditText>(Resource.Id.edtTxt_RePassword);

            // Fetch and display user profile data
            LoadUserData();
            UpdateData();
            // Set click listener for the update button
            updateProfile_Btn = FindViewById<Button>(Resource.Id.btn_UpdateProfile);
            updateProfile_Btn.Click += UpdateProfile_Btn;
            updatePass_Btn = FindViewById<Button>(Resource.Id.btn_UpdatePassword);
            updatePass_Btn.Click += UpdatePass_Btn;
        }

        

        private void LoadUserData()
        {
            // Get user data from DB
            root = db.RetrieveDataAzure("SELECT * FROM user_data WHERE email='"+ email +"'", 
                                        null, "user_db");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];

                data_email = u1.GetProperty("email").ToString();
                data_first_name = u1.GetProperty("first_name").ToString();
                data_last_name = u1.GetProperty("last_name").ToString();
                data_birthday = u1.GetProperty("birthday").ToString();
                data_height = u1.GetProperty("height").ToString();
                data_weight = u1.GetProperty("weight").ToString();
                data_bmi = u1.GetProperty("bmi").ToString();
                data_gender = u1.GetProperty("gender").ToString();
            }

            // Get illness from DB
            root = db.RetrieveDataAzure("SELECT * FROM illnesses WHERE email='" + email + "'",
                                        null, "user_db");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];
                //data_email = u1.GetProperty("email").ToString();
                data_illness[i] = u1.GetProperty("types").ToString();
            }
            // Debug/Testing
            /*
            for (int i = 0;i < data_illness.Length; i++)
                Console.WriteLine(data_illness[i]);
            */
        }

        // Display Data
        private void UpdateData() 
        {
            if (data_gender == "M") { data_gender = "Male"; }
            else if (data_gender == "F") { data_gender = "Female"; }

            split_bday = data_birthday.Split('-');
            databyear = split_bday[0];
            data_bmonth = split_bday[1];
            string[] daytime = split_bday[2].Split('T');
            data_bday = daytime[0];

            ageTxt.Text = ConvertBirthdayToAge().ToString();

            switch (data_bmonth)
            {
                case "01": data_bmonth = "January"; break;
                case "02": data_bmonth = "February"; break;
                case "03": data_bmonth = "March"; break;
                case "04": data_bmonth = "April"; break;
                case "05": data_bmonth = "May"; break;
                case "06": data_bmonth = "June"; break;
                case "07": data_bmonth = "July"; break;
                case "08": data_bmonth = "August"; break;
                case "09": data_bmonth = "September"; break;
                case "10": data_bmonth = "October"; break;
                case "11": data_bmonth = "November"; break;
                case "12": data_bmonth = "December"; break;
            }

            // Display Data
            emailTxt.Text = email;

            firstNameEditText.Text = data_first_name;
            lastNameEditText.Text = data_last_name;

            birthdayTxt.Text = data_bmonth + " " + data_bday + ", " + databyear;
            genderTxt.Text = data_gender;

            height.Text = data_height;
            weight.Text = data_weight;
            //bmi.Text = data_bmi; // No need to uncomment because textchanged event will trigger bmi from height and weight editboxes

            for (int i = 0; i < data_illness.Length; i++)
            {
                if (ill_HD.Text == data_illness[i]) // Heart Disease
                    ill_HD.Checked = true;
                else if (ill_D.Text == data_illness[i]) // Diabetes
                    ill_D.Checked = true;
                else if (ill_C.Text == data_illness[i]) // Cancer
                    ill_C.Checked = true;
            }
           
        }

        // Dynamically show error prompt in input field

        private void InputProfileText_TextChanged(object sender, TextChangedEventArgs e)
        {
            EditText value = (EditText)sender;

            if (value.Text == "")
                value.Error = "Please enter your Firstname!";
            //else if (!(Regex.IsMatch(value.Text, @"^[\p{L}]+$")))
            else if (!(Regex.IsMatch(value.Text, @"^[A-Za-zÀ-ÖØ-öø-ÿ]+([-'\s][A-Za-zÀ-ÖØ-öø-ÿ]+)*$")))
                value.Error = "Name must only contain letters!";
            if (value.Text == "")
                value.Error = "Please enter your Lastname!";
            //else if (!(Regex.IsMatch(value.Text, @"^[\p{L}]+$")))
            else if (!(Regex.IsMatch(value.Text, @"^[A-Za-zÀ-ÖØ-öø-ÿ]+([-'\s][A-Za-zÀ-ÖØ-öø-ÿ]+)*$")))
                value.Error = "Name must only contain letters!";
        }
        private void InputProfileNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            EditText value = (EditText)sender;

            if (value.Text == "")
                value.Error = "Empty value!";
            else if (value.Text == "0")
                value.Error = "Value cannot have 0 value!";
        }
        
        private void DynamicValidation_Profile()
        {
            if (firstNameEditText.Text == "")
                firstNameEditText.Error = "Please enter your Firstname!";
            //else if (!(Regex.IsMatch(firstNameEditText.Text, @"^[\p{L}]+$")))
            else if (!(Regex.IsMatch(firstNameEditText.Text, @"^[A-Za-zÀ-ÖØ-öø-ÿ]+([-'\s][A-Za-zÀ-ÖØ-öø-ÿ]+)*$")))
                firstNameEditText.Error = "Name must only contain letters!";
            if (lastNameEditText.Text == "")
                lastNameEditText.Error = "Please enter your Lastname!";
            //else if (!(Regex.IsMatch(lastNameEditText.Text, @"^[\p{L}]+$")))
            else if (!(Regex.IsMatch(lastNameEditText.Text, @"^[A-Za-zÀ-ÖØ-öø-ÿ]+([-'\s][A-Za-zÀ-ÖØ-öø-ÿ]+)*$")))
                lastNameEditText.Error = "Name must only contain letters!";

            if (height.Text == "")
                height.Error = "Please enter your Weight!";
            else if (height.Text == "0")
                height.Error = "Height cannot have 0 value!";

            if (weight.Text == "")
                weight.Error = "Please enter your Height!";
            else if (weight.Text == "0")
                weight.Error = "Weight cannot have 0 value!";
        }

        // Calculate BMI from the user inputs height and weight
        private void GetBMI(object sender, EventArgs e)
        {
            try
            {
                bmivalue = Convert.ToDecimal(weight.Text) / Convert.ToDecimal(Math.Pow(Convert.ToDouble(height.Text), 2));
                bmivalue = Math.Round(bmivalue, 2);
                bmi.Text = Convert.ToString(bmivalue);

                if ((double)bmivalue < 18.5)
                    BMI_Classification.Text = "Underweight";
                else if ((double)bmivalue >= 18.5 && (double)bmivalue < 24.9)
                    BMI_Classification.Text = "Normal weight";
                else if ((double)bmivalue >= 25 && (double)bmivalue < 29.9)
                    BMI_Classification.Text = "Overweight";
                else
                    BMI_Classification.Text = "Obese";
            }
            catch 
            { 
                bmi.Text = "0";
                BMI_Classification.Text = "Invalid BMI!";
            }
        }
        public double ConvertBirthdayToAge() // Convert Birthday to Age
        {
            /* Jonard's Note:
            This will accurately get the age especially if the month or day was passed or not. 
            *(my explanation is bad lol so here's the example)
            *
            Example: User's birthday is 2024-06-20
                Then, if the date is 2001-06-21. Therefore, user's age is 23
                Then, if the date is 2001-06-19. Therefore, user's age is 22 because it haven't reached their birthday for this year
             */
            string[] birthdate_split = new string[2];
            birthdate_split = data_birthday.Split('-'); // YYYY-MM-DD

            if (Int32.Parse(birthdate_split[1]) < DateTime.Now.Month ||
                (Int32.Parse(birthdate_split[1]) == DateTime.Now.Month && Int32.Parse(birthdate_split[2]) < DateTime.Now.Day))
                return (DateTime.Now.Year - Int32.Parse(birthdate_split[0])) - 1;
            return DateTime.Now.Year - Int32.Parse(birthdate_split[0]);
        }

        // Update Profile Details
        private void UpdateProfile_Btn(object sender, EventArgs e)
        { 
            if (Validation())
            {
                db.InsertDataAzure("UPDATE user_data SET " +
                    "first_name='" + firstNameEditText.Text + "', " +
                    "last_name='" + lastNameEditText.Text + "', " +
                    "height='" + height.Text + "', " +
                    "weight='" + weight.Text + "', " +
                    "bmi='" + bmi.Text + "'" +
                    "WHERE email='" + email + "'",
                    "user_db");

                SaveIllness();

                Toast.MakeText(this, "Account Updated Successfully!", ToastLength.Long).Show();
            }
            else Toast.MakeText(this, "Unable to Update!", ToastLength.Long).Show();
        }

        //Validation
        public bool Validation()
        {
            if (firstNameEditText.Text == "" || !(Regex.IsMatch(firstNameEditText.Text, @"^[A-Za-zÀ-ÖØ-öø-ÿ]+([-'\s][A-Za-zÀ-ÖØ-öø-ÿ]+)*$")) || //!(Regex.IsMatch(firstNameEditText.Text, @"^[\p{L}]+$")) ||
                lastNameEditText.Text == "" || !(Regex.IsMatch(firstNameEditText.Text, @"^[A-Za-zÀ-ÖØ-öø-ÿ]+([-'\s][A-Za-zÀ-ÖØ-öø-ÿ]+)*$")) || //!(Regex.IsMatch(lastNameEditText.Text, @"^[\p{L}]+$")) ||
                height.Text == "" || height.Text == "0" || weight.Text == "" || weight.Text == "0")
            {
                DynamicValidation_Profile();
                return false;
            }

            return true;
        }

        // Insert Illness
        public void SaveIllness()
        {
            db.InsertDataAzure("DELETE FROM illnesses WHERE email='"+ email +"'", "user_db");

            if (ill_HD.Checked)
                db.InsertDataAzure("INSERT INTO illnesses VALUES ('" + email + "', '" + ill_HD.Text + "')", "user_db");
            if (ill_D.Checked)
                db.InsertDataAzure("INSERT INTO illnesses VALUES ('" + email + "', '" + ill_D.Text + "')", "user_db");
            if (ill_C.Checked)
                db.InsertDataAzure("INSERT INTO illnesses VALUES ('" + email + "', '" + ill_C.Text + "')", "user_db");
            if (!ill_HD.Checked && !ill_D.Checked && !ill_C.Checked)
                db.InsertDataAzure("INSERT INTO illnesses VALUES ('" + email + "', 'Healthy')", "user_db");
        }

        // Update Password
        private void UpdatePass_Btn(object sender, EventArgs e)
        {
            if (IsValid_CurrentPass())
            {
                if (newPassword.Text == "" || (newPassword.Text).Length < 8 ||
                    rePassword.Text == "" || rePassword.Text != rePassword.Text)
                    Validation_ChangePass();
                else
                {
                    db.InsertDataAzure("UPDATE login SET " +
                                       "password=HASHBYTES('SHA2_256', '" + newPassword.Text + "')" +
                                       "WHERE email='"+ email +"' AND acct_type='user'", 
                                       "user_db");
                    Toast.MakeText(this, "Password Updated Successfully!", ToastLength.Long).Show();
                }

            }
            else
                currentPassword.Error = "Invalid Password!";
        }

        private bool IsValid_CurrentPass()
        {
            root = db.RetrieveDataAzure("SELECT * FROM login WHERE email='" + email + "' AND password=HASHBYTES('SHA2_256', '" + currentPassword.Text + "')  AND acct_type='user'",
                                        null, "user_db");

            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];
                string searchemail = u1.GetProperty("email").ToString();

                if (searchemail == email)
                    return true;
            }
            return false;
        }

        private void Validation_ChangePass()
        {
            if (newPassword.Text == "")
                newPassword.Error = "Please enter your Password!";
            else if ((newPassword.Text).Length < 8)
                newPassword.Error = "Password must be minimum of 8 characters!";
            if (rePassword.Text == "")
                rePassword.Error = "Please re-type your Password!";
            else if (rePassword.Text != rePassword.Text)
                rePassword.Error = "Passwords do not match!";
        }

        // ============ built-in template functions for drawer (code starts here) =======================
        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if (drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                OpenWebLink("https://www.canva.com/design/DAF-j62aMQg/G1IK-EeQPP3ZUL7q-K_qyg/edit?utm_content=DAF-j62aMQg&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton");
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
        private void OpenWebLink(string url)
        {
            Intent intent = new Intent(Intent.ActionView, Android.Net.Uri.Parse(url));
            StartActivity(intent);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            Type page = selectedNav.SelectedNavigation(item);

            if (page == typeof(MainActivity))
            {
                // Remove the token
                AuthService.RemoveAuthToken();

                // Clear global data
                TempDataService.ClearGlobalData();
                FinishAffinity();
                Intent i = new Intent(this, page);
                StartActivity(i);

            }
            else
            {


                Intent i = new Intent(this, page);
                StartActivity(i);

                DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
                drawer.CloseDrawer(GravityCompat.Start);
            }

            return true;
        }
        // ============ built-in template functions for drawer (code ends here) =======================



    }

}