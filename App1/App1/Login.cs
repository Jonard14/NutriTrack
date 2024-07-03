using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.Hardware.Lights;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using static Android.Provider.DocumentsContract;

namespace App1
{
    [Activity(Label = "Login", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Login : Activity
    {
        EditText email, password;
        Button login, home;
        TextView register, forgotpass;
        DBClass db = new DBClass();
        JsonElement root;
        string searchemail;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login);

            // Create your application here
            home = FindViewById<Button>(Resource.Id.btn_Home);
            home.Click += Home;

            email = FindViewById<EditText>(Resource.Id.edtTxt_email);
            email.TextChanged += Input_TextChanged;
            password = FindViewById<EditText>(Resource.Id.edtTxt_password);
            password.TextChanged += Input_TextChanged;
            login = FindViewById<Button>(Resource.Id.btn_Login);
            login.Click += loginClick;

            register = FindViewById<TextView>(Resource.Id.txtV_RegisterLink);
            register.PaintFlags = PaintFlags.UnderlineText;
            register.Click += RegisterLink;

            forgotpass = FindViewById<TextView>(Resource.Id.txtv_Forgotpass);
            forgotpass.PaintFlags = PaintFlags.UnderlineText;
            forgotpass.Click += forgotPassLink;

        }

        // Dynamically show error prompt in input field
        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (email.Text == "")
                email.Error = "Please enter your Email!";
            else if (isValidEmail(email.Text) == false)
                email.Error = "Email is not Valid!";

            if (password.Text == "")
                password.Error = "Please enter your Password!";
        }
        // Checks if Email format is valid
        public bool isValidEmail(string email)
        {
            return Android.Util.Patterns.EmailAddress.Matcher(email).Matches();
        }


        public void Home(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(MainActivity));
            StartActivity(i);
        }

        //Login of acct
        public void loginClick(object sender, EventArgs e)
        {
            /* Debug/Testing
            Intent i = new Intent(this, typeof(HomePage));
            StartActivity(i);
            */
            if (VerifyLogin())
            {
                Toast.MakeText(this, "Login successfull!", ToastLength.Long).Show();
                Intent i = new Intent(this, typeof(HomePage));
                i.PutExtra("email", email.Text);
                MyGlobals.Globalemail = email.Text;
                MyGlobals.GlobalCalorie = 0;
                MyGlobals.GlobalSugar = 0;
                MyGlobals.GlobalProtein = 0;
                MyGlobals.GlobalFat = 0;
                MyGlobals.GlobalCholesterol = 0;
                MyGlobals.GlobalCarbohyrates = 0;
                MyGlobals.GlobalSodium = 0;
                StartActivity(i);
            }
            else
            {
                Toast.MakeText(this, "Email or Password are incorrect!", ToastLength.Long).Show();
                email.Error = "Email or Password are incorrect!";
                password.Error = "Email or Password are incorrect!";
            }
        }

        public void RegisterLink(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Register));
            StartActivity(i);
        }

        public void forgotPassLink(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(verifyEmail));
            StartActivity(i);
        }

        // Verify Login if account is registered to db
        public bool VerifyLogin()
        {
            //root = db.RetrieveData("search_accountlogin.php?email=" + email.Text + "&password=" + password.Text);
            root = db.RetrieveDataAzure("SELECT * FROM login WHERE email='"+ email.Text +"' AND password=HASHBYTES('SHA2_256', '"+  password.Text +"')",
                                        null, "user_db");

            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];
                searchemail = u1.GetProperty("email").ToString();

                if (searchemail == email.Text)
                { return true; }
            }
            return false;
        }
        public static class MyGlobals
        {
            public static string Globalemail { get; set; }
            public static float GlobalCalorie { get; set; }
            public static float GlobalSugar { get; set; }
            public static float GlobalFat { get; set; }
            public static float GlobalProtein { get; set; }
            public static float GlobalCholesterol { get; set; }
            public static float GlobalCarbohyrates { get; set; }
            public static float GlobalSodium { get; set; }




        }
    }
}