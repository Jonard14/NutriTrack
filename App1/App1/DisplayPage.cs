using Android.App;
using Android.Content;
using Android.Content.PM;
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

namespace App1
{
    [Activity(Label = "DisplayPage", ScreenOrientation = ScreenOrientation.Portrait)]
    public class DisplayPage : AppCompatActivity//, NavigationView.IOnNavigationItemSelectedListener
    {
        DrawerNavigation selectedNav = new DrawerNavigation();
        DBClass db = new DBClass();
        JsonElement root;

        string searchemail, gender;
        string email = Login.MyGlobals.Globalemail, birthday;
        float CalorieNum,  CalorieDays, TotalCalorie, total_sugar = 0, currentCalorieNum = 0;
        double recommendCalorie, age, height, weight;
        float protein2, fat2, cholesterol2, carbohydrates, sodium2;

        string food_id, food_name, selectedFood;
        float calorie_energy, protein, total_fat, carbohydrate, sugar, sodium, cholesterol,
              calorie_compute, protein_compute, total_fat_compute, carbohydrate_compute, sugar_compute, sodium_compute, cholesterol_compute;
        

        TextView cal, fat, chol, sod, carb, sug, prot, fname;

        TextView  CurrentCalorie, SugarCount;  //TotalCalorieNum,recommendNum,PrevCalorie,
        TextView Tprotein, Tcholesterol, Tfats, Tsodium, Tcarbohydrates;
        EditText portions;

        Button SaveCalorie, ResetSugar;
        Button btn1, btn_add;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.displaypage);

            /*
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
            */


            // Create your application here

            btn1 = FindViewById<Button>(Resource.Id.btn1);
            btn_add = FindViewById<Button>(Resource.Id.btn_Add);

            fname = FindViewById<TextView>(Resource.Id.fName);
            cal = FindViewById<TextView>(Resource.Id.calServ);
            fat = FindViewById<TextView>(Resource.Id.textV_fat);
            chol = FindViewById<TextView>(Resource.Id.textV_cholesterol);
            sod = FindViewById<TextView>(Resource.Id.textV_sodium);
            carb = FindViewById<TextView>(Resource.Id.textV_carbohydrates);
            sug = FindViewById<TextView>(Resource.Id.textV_Sugar);
            prot = FindViewById<TextView>(Resource.Id.textV_protein);

            selectedFood = Intent.GetStringExtra("SelectedFood");
            fname.Text = selectedFood;

            portions = FindViewById<EditText>(Resource.Id.serv_size);
            portions.TextChanged += getNutriContent;

            // Tracker
            //PrevCalorie = FindViewById<TextView>(Resource.Id.textV_NumPrev);
            CurrentCalorie = FindViewById<TextView>(Resource.Id.textV_NumCurrent);
            //TotalCalorieNum = FindViewById<TextView>(Resource.Id.textV_TotalCalorieNum);
            SugarCount = FindViewById<TextView>(Resource.Id.textV_NumSugar);
            //recommendNum = FindViewById<TextView>(Resource.Id.textV_recommendNum);
            Tprotein = FindViewById<TextView>(Resource.Id.textV_numprotein);
            Tcholesterol = FindViewById<TextView>(Resource.Id.textV_numcholesterol);
            Tsodium = FindViewById<TextView>(Resource.Id.textV_numsodium);
            Tcarbohydrates = FindViewById<TextView>(Resource.Id.textV_numcarbohydrates);
            Tfats = FindViewById<TextView>(Resource.Id.textV_numfats);

            /*SaveCalorie = FindViewById<Button>(Resource.Id.btn_saveCalorie);
            SaveCalorie.Click += saveCalorieClick;

            ResetSugar = FindViewById<Button>(Resource.Id.btnn_resetSugar);
            ResetSugar.Click += resetSugarCalorie;*/

            retrieveData(selectedFood);
            updateUI();
            Update();
            btn1.Click += backEvent;
            btn_add.Click += addFood;
        }
        public void backEvent(object sender, EventArgs e)
        {
            if (Intent.GetStringExtra("ActivityPage") == "HomePage")
            {
                Finish();
                Intent i = new Intent(this, typeof(HomePage));
                StartActivity(i);
            }
            else if (Intent.GetStringExtra("ActivityPage") == "DietDisplay")
            {
                Finish();
                Intent i = new Intent(this, typeof(DietDisplay));
                i.PutExtra("SelectedDiet", Intent.GetStringExtra("SelectedDiet"));
                StartActivity(i);
            }
        }

        private void retrieveData(string selectedFood)
        {
            //root = db.RetrieveData("search_fooddata.php?");
            root = db.RetrieveDataAzure("SELECT food_data.food_id, food_data.food_name, nutrients.calorie_energy, nutrients.protein, nutrients.total_fat, nutrients.carbohydrate, nutrients.sugar, nutrients.sodium, nutrients.cholesterol FROM food_data INNER JOIN nutrients ON food_data.food_id = nutrients.food_id ORDER BY food_data.food_name ASC; ",null, "food_db");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];
                //food_id = u1.GetProperty("food_id").ToString();
                //food_name = u1.GetProperty("food_name").ToString();
                string tmpfood_name = u1.GetProperty("food_name").ToString();

                if (selectedFood.Equals(tmpfood_name))
                {
                    food_id = u1.GetProperty("food_id").ToString();
                    food_name = u1.GetProperty("food_name").ToString();
                    calorie_energy = float.Parse(u1.GetProperty("calorie_energy").ToString());
                    protein = float.Parse(u1.GetProperty("protein").ToString());
                    total_fat = float.Parse(u1.GetProperty("total_fat").ToString());
                    carbohydrate = float.Parse(u1.GetProperty("carbohydrate").ToString());
                    sugar = float.Parse(u1.GetProperty("sugar").ToString());
                    sodium = float.Parse(u1.GetProperty("sodium").ToString());
                    cholesterol = float.Parse(u1.GetProperty("cholesterol").ToString());
                } 
            }
        }
        private void updateUI()
        {
            calorie_compute = calorie_energy * float.Parse(portions.Text);
            protein_compute = protein * float.Parse(portions.Text);
            total_fat_compute = total_fat * float.Parse(portions.Text);
            carbohydrate_compute = carbohydrate * float.Parse(portions.Text);
            sugar_compute = sugar * float.Parse(portions.Text);
            sodium_compute = sodium * float.Parse(portions.Text);
            cholesterol_compute = cholesterol * float.Parse(portions.Text);

            cal.Text = "Calories " + Math.Round(calorie_compute, 2).ToString();
            fat.Text = "Total Fat " + Math.Round(total_fat_compute, 2).ToString() + "g";
            chol.Text = "Cholesterol " + Math.Round(cholesterol_compute, 2).ToString() + "mg";
            sod.Text = "Sodium " + Math.Round(sodium_compute, 2).ToString() + "mg";
            carb.Text = "Total Carbohydrates " + Math.Round(carbohydrate_compute, 2).ToString() + "g";
            sug.Text = "Total Sugars " + Math.Round(sugar_compute, 2).ToString() + "g";
            prot.Text = "Protein " + Math.Round(protein_compute, 2).ToString() + "g";
        }

        public void getNutriContent(object sender, TextChangedEventArgs e)
        {
            try
            {
                updateUI();
            }
            catch
            {
                portions.Error = "Invalid Value!";

                fname.Text = selectedFood;
                cal.Text = "Calories 0";
                fat.Text = "Total Fat 0g";
                chol.Text = "Cholesterol 0mg";
                sod.Text = "Sodium 0mg";
                carb.Text = "Total Carbohydrates 0g";
                sug.Text = "Total Sugars 0g";
                prot.Text = "Protein 0g";
            }
        }

        public void addFood(object sender, EventArgs e)
        {
            Login.MyGlobals.GlobalCalorie = (float)Math.Round(Login.MyGlobals.GlobalCalorie + calorie_compute, 2);
            Login.MyGlobals.GlobalSugar = (float)Math.Round(Login.MyGlobals.GlobalSugar + sugar_compute, 2);
            Login.MyGlobals.GlobalFat = (float)Math.Round(Login.MyGlobals.GlobalFat + total_fat_compute, 2);
            Login.MyGlobals.GlobalProtein = (float)Math.Round(Login.MyGlobals.GlobalProtein + protein_compute, 2);
            Login.MyGlobals.GlobalCholesterol = (float)Math.Round(Login.MyGlobals.GlobalCholesterol + cholesterol_compute, 2);
            Login.MyGlobals.GlobalCarbohyrates = (float)Math.Round(Login.MyGlobals.GlobalCarbohyrates + carbohydrate_compute, 2);
            Login.MyGlobals.GlobalSodium = (float)Math.Round(Login.MyGlobals.GlobalSodium + sodium_compute, 2);
            Login.MyGlobals.GlobalFoodList.Add($"{food_name}, {calorie_compute}, {sugar_compute}, {total_fat_compute}, {protein_compute}, {cholesterol_compute}, {carbohydrate_compute}, {sodium_compute}");
            TempDataService.SaveGlobalData();

            Update();
            Toast.MakeText(this, "Food Added", ToastLength.Long).Show();

        }
        public void Update()
        {
            total_sugar = Login.MyGlobals.GlobalSugar;
            currentCalorieNum = Login.MyGlobals.GlobalCalorie;
            protein2 = Login.MyGlobals.GlobalProtein;
            fat2 = Login.MyGlobals.GlobalFat;
            cholesterol2 = Login.MyGlobals.GlobalCholesterol;
            carbohydrates = Login.MyGlobals.GlobalCarbohyrates;
            sodium2 = Login.MyGlobals.GlobalSodium;

            if (VerifyEmail())
            {
                //PrevCalorie.Text = CalorieNum.ToString();
                SugarCount.Text = total_sugar.ToString();
                CurrentCalorie.Text = currentCalorieNum.ToString();
                //TotalCalorieNum.Text = TotalCalorie.ToString();
                Tprotein.Text = protein2.ToString();
                Tcholesterol.Text = cholesterol2.ToString();
                Tfats.Text = fat2.ToString();
                Tcarbohydrates.Text = carbohydrates.ToString();
                Tsodium.Text = sodium2.ToString();

            }
            else
            {
                Toast.MakeText(this, "Unable to Retrieve Data", ToastLength.Long).Show();
            }
            dailyCalorieCalcualte();
        }

        /*public void saveCalorieClick(object sender, EventArgs e)
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
            //PrevCalorie.Text = TotalCalorie.ToString();


            string tracker_log_time = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm\:ss tt");
            //history.Add(tracker_log_time + "\nCalorie Count: " + CurrentCalorie.Text + "\nSugar Count: " + SugarCount.Text);
            string success = db.InsertData("insert_trackerlog.php?email=" + email + "&time_log=" + tracker_log_time + "&calorie_count=" + CurrentCalorie.Text + "&sugar_count=" + SugarCount.Text + "&protein_count=" + Tprotein.Text + "&fats_count=" + Tfats.Text + "&cholesterol_count=" + Tcholesterol.Text + "&carbohydrates_count=" + Tcarbohydrates.Text + "&sodium_count=" + Tsodium.Text);
            Console.WriteLine(success);

            Toast.MakeText(this, "Successfuly saved Calories!", ToastLength.Long).Show();



        }
        public void resetSugarCalorie(object sender, EventArgs e)
        {
            SugarCount.Text = "0";
            CurrentCalorie.Text = "0";
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
            protein2 += Login.MyGlobals.GlobalProtein;
            fat2 += Login.MyGlobals.GlobalFat;
            cholesterol2 += Login.MyGlobals.GlobalCholesterol;
            carbohydrates += Login.MyGlobals.GlobalCarbohyrates;
            sodium2 += Login.MyGlobals.GlobalSodium;

        }*/

        public bool VerifyEmail()
        {
            //root = db.RetrieveData("get_calorie.php?email=" + email);
            root = db.RetrieveDataAzure("SELECT * FROM user_data WHERE email='" + email + "';",null, "user_db");

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

        /*
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
        */
    }
}