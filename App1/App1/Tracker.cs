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
    [Activity(Label = "Tracker")]
    public class Tracker : Activity
    {
        TextView PrevCalorie, CurrentCalorie, SugarCount;
        DBClass db = new DBClass();
        JsonElement root;
        string searchemail;
        string email = Login.MyGlobals.Globalemail;
        string CalorieNum, TotalCalorie, CalorieDays, total_sugar;
        Button SaveCalorie, ResetSugar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.tracker);
            // Create your application here
            PrevCalorie = FindViewById<TextView>(Resource.Id.textV_NumPrev);
            CurrentCalorie = FindViewById<TextView>(Resource.Id.textV_NumCurrent);
            SugarCount = FindViewById<TextView>(Resource.Id.textV_NumSugar);

            SaveCalorie = FindViewById<Button>(Resource.Id.btn_saveCalorie);

        }

        public void Update()
        {
            if (VerifyEmail())
            {
                PrevCalorie.Text = CalorieNum;
                SugarCount.Text = total_sugar;
            }
            else
            {
                Toast.MakeText(this, "Unable to Retrieve Data", ToastLength.Long).Show();
            }
        }
        public bool VerifyEmail()
        {
            root = db.RetrieveData("get_calorie.php?email=" + email);

            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];
                searchemail = u1.GetProperty("email").ToString();
                CalorieNum = u1.GetProperty("daily_calorie_intake").ToString();
                TotalCalorie = u1.GetProperty("total_calorie_intake").ToString();
                CalorieDays = u1.GetProperty("calorie_intake_days").ToString();

                if (searchemail == email)
                { return true; }
            }
            return false;
        }
    }
}