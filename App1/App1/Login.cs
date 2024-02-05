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

/* Summary I've done in login.xml -Jonard
        email                           - Set to email type
        password                        - Set to password type
 */

namespace App1
{
    [Activity(Label = "Login")]
    public class Login : Activity
    {
        EditText email, password;
        Button login, home;
        TextView register;

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

        public void loginClick(object sender, EventArgs e)
        {
            if (email.Text == "admin@admin.com" &&  password.Text == "12345") 
            {
                Toast.MakeText(this, "Login successfully done!", ToastLength.Long).Show();
                Intent i = new Intent(this, typeof(HomePage));
                i.PutExtra("email", email.Text);
                StartActivity(i);
            }
            else
            {
                Toast.MakeText(this, "Wrong credentials found!", ToastLength.Long).Show();
            }
        }

        public void RegisterLink(object sender, EventArgs e) 
        {
            Intent i = new Intent(this, typeof(Register));
            StartActivity(i);
        }
    }
}