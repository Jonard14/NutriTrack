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
    public class DisplayPage : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DrawerNavigation selectedNav = new DrawerNavigation();
        DBClass db = new DBClass();
        JsonElement root;
        string food_id, food_name, selectedFood;
        float calorie_energy, protein, total_fat, carbohydrate, sugar, sodium, cholesterol,
              calorie_compute, protein_compute, total_fat_compute, carbohydrate_compute, sugar_compute, sodium_compute, cholesterol_compute;
        string cal_comp, fat_comp;

        TextView cal, fat, chol, sod, carb, sug, prot, fname;
        EditText portions;


        private Button btn1, btn_add;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.displaypage_drawer);

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

            retrieveData(selectedFood);
            updateUI();
            btn1.Click += backEvent;
            btn_add.Click += addFood;
        }
        public void backEvent(object sender, EventArgs e)
        {
            if (Intent.GetStringExtra("ActivityPage") == "HomePage")
            {
                Intent i = new Intent(this, typeof(HomePage));
                StartActivity(i);
            }
            else if (Intent.GetStringExtra("ActivityPage") == "SuggestFood")
            {
                Intent i = new Intent(this, typeof(SuggestFood));
                StartActivity(i);
            }
        }

        private void retrieveData(string selectedFood)
        {
            root = db.RetrieveData("search_fooddata.php?");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];
                food_id = u1.GetProperty("food_id").ToString();
                food_name = u1.GetProperty("food_name").ToString();

                if (selectedFood.Equals(food_name))
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
            Login.MyGlobals.GlobalCalorie = Login.MyGlobals.GlobalCalorie + calorie_compute;
            Login.MyGlobals.GlobalSugar = Login.MyGlobals.GlobalSugar + sugar_compute;
            Login.MyGlobals.GlobalFat = Login.MyGlobals.GlobalFat + total_fat_compute;
            Login.MyGlobals.GlobalProtein = Login.MyGlobals.GlobalProtein + protein_compute;
            Login.MyGlobals.GlobalCholesterol = Login.MyGlobals.GlobalCholesterol + cholesterol_compute;
            Login.MyGlobals.GlobalCarbohyrates = Login.MyGlobals.GlobalCarbohyrates + carbohydrate_compute;
            Login.MyGlobals.GlobalSodium = Login.MyGlobals.GlobalSodium + sodium_compute;


            Toast.MakeText(this, "Food Added", ToastLength.Long).Show();

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