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
using System.Collections;
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
        TextView PrevCalorie, CurrentCalorie, SugarCount, TotalCalorieNum, recommendNum;
        DBClass db = new DBClass();
        JsonElement root;

        DrawerNavigation selectedNav = new DrawerNavigation();

        string searchemail, gender;
        string email = Login.MyGlobals.Globalemail;
        float CalorieNum, TotalCalorie, CalorieDays, total_sugar = 0, currentCalorieNum = 0;
        Button SaveCalorie, ResetSugar;
        double recommendCalorie, age, height, weight;

        private ListView lv;
        private ArrayList history;
        private ArrayAdapter _adapter;

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
            recommendNum = FindViewById<TextView>(Resource.Id.textV_recommendNum);

            SaveCalorie = FindViewById<Button>(Resource.Id.btn_saveCalorie);
            SaveCalorie.Click += saveCalorieClick;

            ResetSugar = FindViewById<Button>(Resource.Id.btnn_resetSugar);
            ResetSugar.Click += resetSugarCalorie;

            history = new ArrayList();
            lv = FindViewById<ListView>(Resource.Id.listview1);



            Update();
            retrieveTrackerLog();
            updateLog();
        }

        public void Update()
        {
            total_sugar += Login.MyGlobals.GlobalSugar;
            currentCalorieNum += Login.MyGlobals.GlobalCalorie;

            if (VerifyEmail())
            {
                PrevCalorie.Text = CalorieNum.ToString();
                SugarCount.Text = total_sugar.ToString();
                CurrentCalorie.Text = currentCalorieNum.ToString();
                TotalCalorieNum.Text = TotalCalorie.ToString();

            }
            else
            {
                Toast.MakeText(this, "Unable to Retrieve Data", ToastLength.Long).Show();
            }
            dailyCalorieCalcualte();
        }

        public void saveCalorieClick(object sender, EventArgs e)
        {
            VerifyEmail();
            float totalCalNum = TotalCalorie;
            float currentCal = currentCalorieNum;
            float calorieDays = CalorieDays;
            calorieDays = calorieDays + 1;

            float prevCal = CalorieNum;
            prevCal = (currentCal + totalCalNum) / calorieDays;

            string prevCalString = prevCal.ToString();
            string stringCalDays = calorieDays.ToString();
            TotalCalorie = currentCal + totalCalNum;

            db.InsertData("update_calorie.php?email=" + email + "&daily_calorie_intake=" + prevCalString + "&total_calorie_intake=" + TotalCalorie + "&calorie_intake_days=" + stringCalDays);
            PrevCalorie.Text = TotalCalorie.ToString();


            string tracker_log_time = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm\:ss tt");
            //history.Add(tracker_log_time + "\nCalorie Count: " + CurrentCalorie.Text + "\nSugar Count: " + SugarCount.Text);
            db.InsertData("insert_trackerlog.php?email=" + email + "&time_log=" + tracker_log_time + "&calorie_count=" + CurrentCalorie.Text + "&sugar_count=" + SugarCount.Text);
            retrieveTrackerLog();
            updateLog();

            Toast.MakeText(this, "Successfuly saved Calories!", ToastLength.Long).Show();



        }

        public void resetSugarCalorie(object sender, EventArgs e)
        {
            SugarCount.Text = "0";
            total_sugar = 0;
            CurrentCalorie.Text = "0";
            currentCalorieNum = 0;
            Login.MyGlobals.GlobalSugar = total_sugar;
            Login.MyGlobals.GlobalCalorie = currentCalorieNum;

        }

        public bool VerifyEmail()
        {
            root = db.RetrieveData("get_calorie.php?email=" + email);

            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];
                searchemail = u1.GetProperty("email").ToString();
                CalorieNum = float.Parse(u1.GetProperty("daily_calorie_intake").ToString());
                TotalCalorie = float.Parse(u1.GetProperty("total_calorie_intake").ToString());
                CalorieDays = float.Parse(u1.GetProperty("calorie_intake_days").ToString());
                age = double.Parse(u1.GetProperty("age").ToString());
                height = double.Parse(u1.GetProperty("height").ToString());
                weight = double.Parse(u1.GetProperty("weight").ToString());
                gender = u1.GetProperty("gender").ToString();
                if (searchemail == email)
                { return true; }
            }
            return false;
        }

        public void dailyCalorieCalcualte()
        {
            //Females: (10*weight [kg]) + (6.25*height [cm]) – (5*age [years]) – 161
            //Males: (10 * weight[kg]) + (6.25 * height[cm]) – (5 * age[years]) + 5

            height = height * 100; //convert meter to cm

            if (gender == "M")
            {
                recommendCalorie = (10 * weight) + (6.25 * height) - (5 * age) + 5;
                recommendNum.Text = recommendCalorie.ToString();

            }
            else if (gender == "F")
            {
                recommendCalorie = (10 * weight) + (6.25 * height) - (5 * age) - 161;
                recommendNum.Text = recommendCalorie.ToString();
            }
        }

        private void updateLog()
        {
            _adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, history);
            lv.Adapter = _adapter;
        }

        private void retrieveTrackerLog()
        {
            history = new ArrayList();

            // Get food data from DB
            root = db.RetrieveData("search_trackerlog.php?");
            try
            {
                for (int i = 0; i < root.GetArrayLength(); i++)
                {
                    var u1 = root[i];
                    if (email == u1.GetProperty("email").ToString())
                    {
                        history.Add(u1.GetProperty("time_log").ToString() +
                                    "\nCalorie Count: " + u1.GetProperty("calorie_count").ToString() + " kcal" +
                                    "\nSugar Count: " + u1.GetProperty("sugar_count").ToString() + " g");
                    }
                }
            }
            catch
            {
                history.Add("No logs available");

            }
            Console.WriteLine(root);
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