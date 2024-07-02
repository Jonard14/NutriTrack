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
    [Activity(Label = "changePass")]
    public class changePass : Activity
    {
        EditText pass, confirmpass;
        Button submitchange;
        string email;
        DBClass db = new DBClass();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.changepass);
            // Create your application here
            pass = FindViewById<EditText>(Resource.Id.edtTxt_pass);
            confirmpass = FindViewById<EditText>(Resource.Id.edtTxt_confirmpass);
            submitchange = FindViewById<Button>(Resource.Id.btn_change);
            email = Intent.GetStringExtra("email");

            submitchange.Click += passChange;
        }

        public void passChange(object sender, EventArgs e)
        {
            if (pass != confirmpass)
            {
                Toast.MakeText(this, "Passwords do not match!", ToastLength.Long).Show();
            }
            else
            {
                Toast.MakeText(this, "Password Change Successfully!", ToastLength.Long).Show();
                db.InsertData("update_password.php?email=" + email + "&password=" + confirmpass);
                Intent i = new Intent(this, typeof(Login));
                StartActivity(i);
            }
        }
    }
}