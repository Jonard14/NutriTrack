using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
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
    [Activity(Label = "DisplayPage")]
    public class DisplayPage : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DrawerNavigation selectedNav = new DrawerNavigation();
        DBClass db = new DBClass();
        JsonElement root;
        string food_id, food_name;
        float calorie_energy, protein, total_fat, carbohydrate, sugar, sodium, cholesterol;
        float portions = 100;

        private TextView tv;
        private TextView tv1;
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
            tv = FindViewById<TextView>(Resource.Id.foodnameTV);
            tv1 = FindViewById<TextView>(Resource.Id.nutritionContentTV);

            string selectedFood = Intent.GetStringExtra("SelectedFood");
            updateUI(selectedFood);

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
        private void updateUI(string selectedFood)
        {
            string nutritionalContent = getNutriContent(selectedFood);
            tv.Text = selectedFood;
            tv1.Text = nutritionalContent;
        }
        private string getNutriContent(string food)
        {
            // Get food data from DB
            root = db.RetrieveData("search_fooddata.php?");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];

                food_id = u1.GetProperty("food_id").ToString();
                food_name = u1.GetProperty("food_name").ToString();
                calorie_energy = float.Parse(u1.GetProperty("calorie_energy").ToString()) * portions;
                protein = float.Parse(u1.GetProperty("protein").ToString()) * portions;
                total_fat = float.Parse(u1.GetProperty("total_fat").ToString()) * portions;
                carbohydrate = float.Parse(u1.GetProperty("carbohydrate").ToString()) * portions;
                sugar = float.Parse(u1.GetProperty("sugar").ToString()) * portions;
                sodium = float.Parse(u1.GetProperty("sodium").ToString()) * portions;
                cholesterol = float.Parse(u1.GetProperty("cholesterol").ToString()) * portions;

                if (food.Equals(food_name))
                {
                    return "\n Size: " + Math.Round(portions, 2) + " g" +
                           "\n Calories: " + Math.Round(calorie_energy, 2) + " kcal" +
                           "\n Protein: " + Math.Round(protein, 2) + " g" +
                           "\n Fat: " + Math.Round(total_fat, 2) + " g" +
                           "\n Carbohydrates: " + Math.Round(carbohydrate, 2) + " g" +
                           "\n Sugar: " + Math.Round(sugar, 2) + " g" +
                           "\n Sodium: " + Math.Round(sodium, 2) + " mg" +
                           "\n Cholesterol: " + Math.Round(cholesterol, 2) + " mg";
                }
            }
            return "Nutritional content not available";
        }

        public void addFood(object sender, EventArgs e)
        {
            Login.MyGlobals.GlobalCalorie = Login.MyGlobals.GlobalCalorie + calorie_energy;
            Login.MyGlobals.GlobalSugar = Login.MyGlobals.GlobalSugar + sugar;
            Login.MyGlobals.GlobalFat = Login.MyGlobals.GlobalFat + total_fat;
            Login.MyGlobals.GlobalProtein = Login.MyGlobals.GlobalProtein + protein;
            Login.MyGlobals.GlobalCholesterol = Login.MyGlobals.GlobalCholesterol + cholesterol;
            Login.MyGlobals.GlobalCarbohyrates = Login.MyGlobals.GlobalCarbohyrates + carbohydrate;
            Login.MyGlobals.GlobalSodium = Login.MyGlobals.GlobalSodium + sodium;


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