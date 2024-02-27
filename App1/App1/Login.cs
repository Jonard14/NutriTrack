using Android.App;
using Android.Content;
using Android.Graphics;
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
    [Activity(Label = "Login")]
    public class Login : Activity
    {
        EditText email, password;
        Button login, home;
        TextView register;
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
            password = FindViewById<EditText>(Resource.Id.edtTxt_password);
            login = FindViewById<Button>(Resource.Id.btn_Login);
            login.Click += loginClick;

            register = FindViewById<TextView>(Resource.Id.txtV_RegisterLink);
            register.PaintFlags = PaintFlags.UnderlineText;
            register.Click += RegisterLink;

        }


        public void Home(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(MainActivity));
            StartActivity(i);
        }

        //Login of acct
        public void loginClick(object sender, EventArgs e)
        {
            /*
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
                StartActivity(i);
            }
            else
            {
                Toast.MakeText(this, "Email or Password are incorrect!", ToastLength.Long).Show();
            }
        }

        public void RegisterLink(object sender, EventArgs e) 
        {
            Intent i = new Intent(this, typeof(Register));
            StartActivity(i);
        }

        // Verify Login if account is registered to db
        public bool VerifyLogin()
        {
            root = db.RetrieveData("search_accountlogin.php?email=" + email.Text + "&password=" + password.Text);

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
        }
    }
}