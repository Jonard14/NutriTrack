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
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Android.Content.PM;

namespace App1
{
    [Activity(Label = "codeverification", ScreenOrientation = ScreenOrientation.Portrait)]
    public class codeverification : Activity
    {
        Button submitcode;
        string email, correctVerificationCode;
        EditText codeField;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.codeverify);

            // Create your application here
            email = Intent.GetStringExtra("email");
            correctVerificationCode = Intent.GetStringExtra("verificationCode");
            codeField = FindViewById<EditText>(Resource.Id.edtTxt_codeField);
            submitcode = FindViewById<Button>(Resource.Id.btn_verifycode);
            submitcode.Click += verifyCode;
        }

        public void verifyCode(object sender, EventArgs e)
        {
            if(codeField.Text == correctVerificationCode)
            {
                Toast.MakeText(this, "Verification code is correct!", ToastLength.Long).Show();
                Intent i = new Intent(this, typeof(changePass));
                i.PutExtra("email", email);
                StartActivity(i);
            }
            else
            {
                Toast.MakeText(this, "Verification code is incorrect!", ToastLength.Long).Show();
                codeField.Error = "Verification code is incorrect!";
            }
        }

    }
}