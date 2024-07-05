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
    [Activity(Label = "changePass", ScreenOrientation = ScreenOrientation.Portrait)]
    public class changePass : Activity
    {
        EditText pass, confirmpass;
        Button submitchange, back;
        string email;
        DBClass db = new DBClass();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.changepass);
            // Create your application here
            back = FindViewById<Button>(Resource.Id.btn_Back);
            back.Click += Back_Click;

            pass = FindViewById<EditText>(Resource.Id.edtTxt_pass);
            confirmpass = FindViewById<EditText>(Resource.Id.edtTxt_confirmpass);
            submitchange = FindViewById<Button>(Resource.Id.btn_change);
            email = Intent.GetStringExtra("email");

            pass.TextChanged += Input_TextChanged;
            confirmpass.TextChanged += Input_TextChanged;
            submitchange.Click += passChange;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Finish();   
            Intent i = new Intent(this, typeof(verifyEmail));
            StartActivity(i);
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            DynamicValidation();
        }


        private void DynamicValidation()
        {
            if (pass.Text == "")
                pass.Error = "Please enter your Password!";
            else if ((pass.Text).Length < 8)
                pass.Error = "Password must be minimum of 8 characters!";
            if (confirmpass.Text == "")
                confirmpass.Error = "Please re-type your Password!";
            else if (pass.Text != confirmpass.Text)
                confirmpass.Error = "Passwords do not match!";
        }

        public void passChange(object sender, EventArgs e)
        {
            if (pass.Text == "" || (pass.Text).Length < 8 || confirmpass.Text == "" ||
                pass.Text != confirmpass.Text)
            {
                DynamicValidation();
                Toast.MakeText(this, "Unable to Change Password!", ToastLength.Long).Show();
            }
            else
            {
                Toast.MakeText(this, "Password Change Successfully!", ToastLength.Long).Show();

                //db.InsertData("update_password.php?email=" + email + "&password=" + pass.Text);
                db.InsertDataAzure("UPDATE login SET password=HASHBYTES('SHA2_256', '"+  pass.Text +"') WHERE email='"+ email +"'",
                                   "user_db");

                Intent i = new Intent(this, typeof(Login));
                StartActivity(i);
            }
        }
    }
}