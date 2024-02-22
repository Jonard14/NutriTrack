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

namespace App1
{
    [Activity(Label = "DisplayPage")]
    public class DisplayPage : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DrawerNavigation selectedNav = new DrawerNavigation();

        private TextView tv;
        private TextView tv1;
        private Button btn1;
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
            tv = FindViewById<TextView>(Resource.Id.foodnameTV);
            tv1 = FindViewById<TextView>(Resource.Id.nutritionContentTV);

            string selectedFood = Intent.GetStringExtra("SelectedFood");
            updateUI(selectedFood);

            btn1.Click += backEvent;
        }
        public void backEvent(object sender,  EventArgs e)
        {
            Intent i = new Intent(this, typeof(HomePage));
            StartActivity(i);
        }
        private void updateUI(string selectedFood)
        {
            string nutritionalContent = getNutriContent(selectedFood);
            tv.Text = selectedFood;
            tv1.Text = nutritionalContent;
        }
        private string getNutriContent(string food)
        {
            if (food.Equals("Chicken Breast Fillet"))
            {
                return "\n Size: 100g \n Calories: 112kcal \n Protein: 22.5g \n Fat: 1.93g \n Carbohydrates: 0g \n Sodium: 66mg \n Cholesterol: 73mg \n Sugar: 0g";
            }
            if (food.Equals("Chicken Thigh"))
            {
                return "\n Size: 100g \n Calories: 149kcal \n Protein: 18.6g \n Fat: 7.92g \n Carbohydrates: 0g \n Cholesterol 92mg \n Sugar: 0g";
            }
            if (food.Equals("Fried Tofu"))
            {
                return "\n Size: 100g \n Calories: 270kcal \n Protein 18.8g \n Fat: 20.2g \n Carbohydrates: 8.9g \n Cholesterol: 0mg \n Sodium: 16mg \n Sugar: 0g";
            }
            if (food.Equals("Bangus"))
            {
                return "\n Size: 100g \n Calories: 223kcal \n Protein 23.4g \n Fat: 13.6g \n Carbohydrates: 0.3g \n Cholesterol: 59.2mg \n Sodium: 241.8mg \n Sugar: 0g";
            }
            if (food.Equals("Tilapia"))
            {
                return "\n Size: 100g \n Calories: 237kcal \n Protein 17.2g \n Fat: 13.5g \n Carbohydrates: 11.7g \n Cholesterol: 44mg \n Sodium: 383mg \n Sugar: 0.2g";
            }
            if (food.Equals("Shrimp"))
            {
                return "\n Size: 100g \n Calories: 218kcal \n Protein 12.3g \n Fat: 12.9g \n Carbohydrates: 12.4g \n Cholesterol: 102mg \n Sodium: 434mg \n Sugar: 0.2g";
            }
            if (food.Equals("Lean Beef"))
            {
                return "\n Size: 100g \n Calories: 230kcal \n Protein 26.5g \n Fat: 20.2g \n Carbohydrates: 13.8g \n Cholesterol: 79mg \n Sodium: 364mg \n Sugar: 0g";
            }
            if (food.Equals("Pork Belly"))
            {
                return "\n Size: 100g \n Calories: 404kcal \n Protein 26.6g \n Fat: 32.2g \n Carbohydrates: 0g \n Cholesterol: 104mg \n Sodium: 448mg \n Sugar: 0g";
            }
            if (food.Equals("Greek Yogurt(Non-Fat)"))
            {
                return "\n Size: 100g \n Calories: 59kcal \n Protein 10g \n Fat: 0.4g \n Carbohydrates: 3.6g \n Cholesterol: 5mg \n Sodium: 36mg \n Sugar: 3.2g";
            }
            if (food.Equals("Crab"))
            {
                return "\n Size: 100g \n Calories: 83kcal \n Protein 17.9g \n Fat: 0.74g \n Carbohydrates: 0g \n Cholesterol: 97mg \n Sodium: 395mg \n Sugar: 0g";
            }

            return "Nutritional content not available";
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