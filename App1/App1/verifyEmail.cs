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
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace App1
{
    [Activity(Label = "verifyEmail", ScreenOrientation = ScreenOrientation.Portrait)]
    public class verifyEmail : Activity
    {
        EditText email;
        Button verify, back;
        JsonElement root;
        DBClass db = new DBClass();
        string searchemail;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.verifyemail);

            // Create your application 
            back = FindViewById<Button>(Resource.Id.btn_Back);
            back.Click += Back_Click;

            email = FindViewById<EditText>(Resource.Id.edtTxt_email);
            verify = FindViewById<Button>(Resource.Id.btn_verify);

            verify.Click += emailverify;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Login));
            StartActivity(i);
        }

        public void emailverify(object sender, EventArgs e)
        {
            if (verification())
            {
                string verificationCode = generateVerificationCode();
                sendVerificationEmail(email.Text, verificationCode);
                Toast.MakeText(this, "Ang Sarap!", ToastLength.Long).Show();
                Intent i = new Intent(this, typeof(codeverification));
                i.PutExtra("email", email.Text);
                i.PutExtra("verificationCode", verificationCode);
                StartActivity(i);
            }
            else
            {
                Toast.MakeText(this, "Email is incorrect!", ToastLength.Long).Show();
                email.Error = "Email is incorrect!";
            }
        }

        public bool verification()
        {
            //root = db.RetrieveData("search_accountforgot.php?email=" + email.Text);
            root = db.RetrieveDataAzure("SELECT * FROM login WHERE email='"+ email.Text +"'",
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

        public string generateVerificationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        static void sendVerificationEmail(string email, string verificationcode)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("jmoriarty031@gmail.com", "gerico@31"),
                    EnableSsl = true,

                };
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("tolaybagz@gmail.com"),
                    Subject = "Your Verification Code",
                    Body = $"Your verification code is {verificationcode}",
                    IsBodyHtml = false,
                };
                mailMessage.To.Add(email);

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Email Sending Failed: " + ex.Message);
            }
        }
    }
}