using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Hardware.Lights;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.Navigation;
using Google.Android.Material.Snackbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using static Android.Provider.DocumentsContract;

namespace App1
{
    [Activity(Label = "Tracker")]
    public class Tracker : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        TextView PrevCalorie, CurrentCalorie, SugarCount, TotalCalorieNum;
        DBClass db = new DBClass();
        JsonElement root;

        DrawerNavigation selectedNav = new DrawerNavigation();

        string searchemail;
        string email = Login.MyGlobals.Globalemail;
        string CalorieNum="0", TotalCalorie="0", CalorieDays="0", total_sugar = "0",currentCalorieNum="0";
        Button SaveCalorie, ResetSugar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.tracker_drawer);

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
            PrevCalorie = FindViewById<TextView>(Resource.Id.textV_NumPrev);
            CurrentCalorie = FindViewById<TextView>(Resource.Id.textV_NumCurrent);
            TotalCalorieNum = FindViewById<TextView>(Resource.Id.textV_TotalCalorieNum);
            SugarCount = FindViewById<TextView>(Resource.Id.textV_NumSugar);

            SaveCalorie = FindViewById<Button>(Resource.Id.btn_saveCalorie);
            SaveCalorie.Click += saveCalorieClick;

            ResetSugar = FindViewById<Button>(Resource.Id.btnn_resetSugar);
            ResetSugar.Click += resetSugar;

            //Update();

        }

        public void Update()
        {
            if (VerifyEmail())
            {
                PrevCalorie.Text = CalorieNum;
                SugarCount.Text = total_sugar;
                CurrentCalorie.Text = currentCalorieNum;
                TotalCalorieNum.Text = TotalCalorie;

            }
            else
            {
                Toast.MakeText(this, "Unable to Retrieve Data", ToastLength.Long).Show();
            }
        }

        public void saveCalorieClick(object sender, EventArgs e)
        {
            int totalCalNum = Int32.Parse(TotalCalorie);
            int currentCal = Int32.Parse(currentCalorieNum);
            int calorieDays=Int32.Parse(CalorieDays);
            calorieDays = calorieDays + 1;
            
            int prevCal = Int32.Parse(CalorieNum);
            prevCal = (currentCal + totalCalNum) / calorieDays;
            
            string prevCalString = prevCal.ToString();
            string stringCalDays = calorieDays.ToString();

            db.InsertData("update_calorie.php?email="+email+ "&daily_calorie_intake"+prevCalString+"&total_calorie_intake"+ TotalCalorie + "&calorie_intake_days"+stringCalDays);
            
            Toast.MakeText(this, "Successfuly saved Calories!", ToastLength.Long).Show();
        }

        public void resetSugar(object sender, EventArgs e)
        {
            SugarCount.Text = "0";
            total_sugar = "0";
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
                return true;
            }

            return base.OnOptionsItemSelected(item);
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

            Intent i = new Intent(this, page);
            StartActivity(i);
            
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
        // ============ built-in template functions for drawer (code ends here) =======================


    }
}