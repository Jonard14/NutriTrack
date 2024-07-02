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
    [Activity(Label = "Tracker", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Tracker : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        TextView PrevCalorie, CurrentCalorie, SugarCount, TotalCalorieNum, recommendNum, numOfCal;
        DBClass db = new DBClass();
        JsonElement root;

        TextView Tprotein, Tcholesterol, Tfats, Tsodium, Tcarbohydrates;
        LinearLayout estim;

        DrawerNavigation selectedNav = new DrawerNavigation();

        string searchemail, gender;
        string email = Login.MyGlobals.Globalemail, birthday;
        float CalorieNum, TotalCalorie, CalorieDays, total_sugar = 0, currentCalorieNum = 0, prog = 0;
        Button SaveCalorie, ResetSugar;
        double recommendCalorie, age, height, weight;
        float protein, fat, cholesterol, carbohydrates, sodium, d;

        ProgressBar pieChart;

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
            estim = FindViewById<LinearLayout>(Resource.Id.linearLayout5);
            PrevCalorie = FindViewById<TextView>(Resource.Id.textV_NumPrev);
            //CurrentCalorie = FindViewById<TextView>(Resource.Id.textV_NumCurrent);
            //TotalCalorieNum = FindViewById<TextView>(Resource.Id.textV_TotalCalorieNum);
            SugarCount = FindViewById<TextView>(Resource.Id.textV_NumSugar);
            //recommendNum = FindViewById<TextView>(Resource.Id.textV_recommendNum);
            numOfCal = FindViewById<TextView>(Resource.Id.number_of_calories);

            pieChart = FindViewById<ProgressBar>(Resource.Id.stats_progressbar);

            SaveCalorie = FindViewById<Button>(Resource.Id.btn_saveCalorie);
            SaveCalorie.Click += saveCalorieClick;

            ResetSugar = FindViewById<Button>(Resource.Id.btnn_resetSugar);
            ResetSugar.Click += resetSugarCalorie;

            estim.Click += estimClick;

            history = new ArrayList();
            lv = FindViewById<ListView>(Resource.Id.listview1);

            //Other Textviews
            Tprotein = FindViewById<TextView>(Resource.Id.textV_numprotein);
            Tcholesterol = FindViewById<TextView>(Resource.Id.textV_numcholesterol);
            Tsodium = FindViewById<TextView>(Resource.Id.textV_numsodium);
            Tcarbohydrates = FindViewById<TextView>(Resource.Id.textV_numcarbohydrates);
            Tfats = FindViewById<TextView>(Resource.Id.textV_numfats);


            Update();
        }

        private void estimClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Use the app daily to get accurate results", ToastLength.Long).Show();
        }

        public void Update()
        {
            total_sugar += Login.MyGlobals.GlobalSugar;
            currentCalorieNum += Login.MyGlobals.GlobalCalorie;
            protein += Login.MyGlobals.GlobalProtein;
            fat += Login.MyGlobals.GlobalFat;
            cholesterol += Login.MyGlobals.GlobalCholesterol;
            carbohydrates += Login.MyGlobals.GlobalCarbohyrates;
            sodium += Login.MyGlobals.GlobalSodium;

            if (VerifyEmail())
            {
                PrevCalorie.Text = CalorieNum.ToString();
                SugarCount.Text = total_sugar.ToString();
                //CurrentCalorie.Text = currentCalorieNum.ToString();
                //TotalCalorieNum.Text = TotalCalorie.ToString();
                Tprotein.Text = protein.ToString();
                Tcholesterol.Text = cholesterol.ToString();
                Tfats.Text = fat.ToString();
                Tcarbohydrates.Text = carbohydrates.ToString();
                Tsodium.Text = sodium.ToString();

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
            string success = db.InsertData("insert_trackerlog.php?email=" + email + "&time_log=" + tracker_log_time + "&calorie_count=" + currentCalorieNum + "&sugar_count=" + SugarCount.Text + "&protein_count=" + Tprotein.Text + "&fats_count=" + Tfats.Text + "&cholesterol_count=" + Tcholesterol.Text + "&carbohydrates_count=" + Tcarbohydrates.Text + "&sodium_count=" + Tsodium.Text);
            string success2 = db.InsertDataAzure("INSERT INTO tracker_log VALUES (" +"'" +email+ "'" + "," + "'" + tracker_log_time + "'" + "," + "'" + currentCalorieNum + "'" + "," +
                                                           "'" + float.Parse(SugarCount.Text) + "'" + "," + "'" + float.Parse(Tprotein.Text) + "'" + "," + "'" + float.Parse(Tfats.Text) + "'" + "," +
                                                           "'" + float.Parse(Tcholesterol.Text) + "'" + "," + "'" + float.Parse(Tcarbohydrates.Text) + "'" + "," + "'" +
                                                           float.Parse(Tsodium.Text) + "'" + ");");
            Console.WriteLine(success);
            Console.WriteLine(success2);

            Toast.MakeText(this, "Successfuly saved Calories!", ToastLength.Long).Show();



        }

        public void resetSugarCalorie(object sender, EventArgs e)
        {
            SugarCount.Text = "0";
            //CurrentCalorie.Text = "0";
            Tprotein.Text = "0";
            Tcarbohydrates.Text = "0";
            Tsodium.Text = "0";
            Tfats.Text = "0";
            Tcholesterol.Text = "0";

            Login.MyGlobals.GlobalSugar = 0;
            Login.MyGlobals.GlobalCalorie = 0;
            Login.MyGlobals.GlobalProtein = 0;
            Login.MyGlobals.GlobalFat = 0;
            Login.MyGlobals.GlobalCholesterol = 0;
            Login.MyGlobals.GlobalCarbohyrates = 0;
            Login.MyGlobals.GlobalSodium = 0;

            total_sugar += Login.MyGlobals.GlobalSugar;
            currentCalorieNum += Login.MyGlobals.GlobalCalorie;
            protein += Login.MyGlobals.GlobalProtein;
            fat += Login.MyGlobals.GlobalFat;
            cholesterol += Login.MyGlobals.GlobalCholesterol;
            carbohydrates += Login.MyGlobals.GlobalCarbohyrates;
            sodium += Login.MyGlobals.GlobalSodium;

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
                birthday = u1.GetProperty("birthday").ToString();
                height = double.Parse(u1.GetProperty("height").ToString());
                weight = double.Parse(u1.GetProperty("weight").ToString());
                gender = u1.GetProperty("gender").ToString();
                if (searchemail == email)
                { return true; }
            }
            return false;
        }

        public double ConvertBirthdayToAge() // Convert Birthday to Age
        {
            /* Jonard's Note:
            This will accurately get the age especially if the month or day was passed or not. 
            *(my explanation is bad lol so here's the example)
            *
            Example: User's birthday is 2024-06-20
                Then, if the date is 2001-06-21. Therefore, user's age is 23
                Then, if the date is 2001-06-19. Therefore, user's age is 22 because it haven't reached their birthday for this year
             */
            string[] birthdate_split = new string[2];
            birthdate_split = birthday.Split('-'); // YYYY-MM-DD

            if (Int32.Parse(birthdate_split[1]) < DateTime.Now.Month ||
                (Int32.Parse(birthdate_split[1]) == DateTime.Now.Month && Int32.Parse(birthdate_split[2]) < DateTime.Now.Day))
                return (DateTime.Now.Year - Int32.Parse(birthdate_split[0])) - 1;
            return DateTime.Now.Year - Int32.Parse(birthdate_split[0]);
        }

        public void dailyCalorieCalcualte()
        {
            age = ConvertBirthdayToAge();
            //Females: (10*weight [kg]) + (6.25*height [cm]) – (5*age [years]) – 161
            //Males: (10 * weight[kg]) + (6.25 * height[cm]) – (5 * age[years]) + 5

            height = height * 100; //convert meter to cm

            if (gender == "M")
            {
                recommendCalorie = (10 * weight) + (6.25 * height) - (5 * age) + 5;
                //recommendNum.Text = recommendCalorie.ToString();

            }
            else if (gender == "F")
            {
                recommendCalorie = (10 * weight) + (6.25 * height) - (5 * age) - 161;
                //recommendNum.Text = recommendCalorie.ToString();
            }
            //Update chart
            numOfCal.Text = currentCalorieNum.ToString() + "/" + recommendCalorie.ToString();
            d = currentCalorieNum / (float)recommendCalorie;
            prog = d * 100;
            pieChart.Progress = (int)prog;
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