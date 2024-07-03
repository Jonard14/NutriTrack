using Android.App;
using Android.Content;
using Android.Content.PM;
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
    [Activity(Label = "Admin - Add Food", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Admin_AddFood : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DrawerNavigation selectedNav = new DrawerNavigation();

        private EditText foodNameInput, caloriesInput, carbohydratesInput, proteinInput, fatInput, sugarInput, sodiumInput, cholesterolInput;
        private Button submitButton;

        string foodName, calories, carbohydrates, protein, fat, sugar, sodium, cholesterol;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.admin_addfood_drawer);

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


            // Initialize views
            foodNameInput = FindViewById<EditText>(Resource.Id.food_name_input);
            caloriesInput = FindViewById<EditText>(Resource.Id.calories_input);
            carbohydratesInput = FindViewById<EditText>(Resource.Id.carbohydrates_input);
            proteinInput = FindViewById<EditText>(Resource.Id.protein_input);
            fatInput = FindViewById<EditText>(Resource.Id.fat_input);
            sugarInput = FindViewById<EditText>(Resource.Id.sugar_input);
            sodiumInput = FindViewById<EditText>(Resource.Id.sodium_input);
            cholesterolInput = FindViewById<EditText>(Resource.Id.cholesterol_input);
            submitButton = FindViewById<Button>(Resource.Id.submit_button);


            // Set submit button click event
            submitButton.Click += OnSubmitButtonClick;

        }

        private void OnSubmitButtonClick(object sender, EventArgs e)
        {
            foodName = foodNameInput.Text;
            calories = caloriesInput.Text;
            carbohydrates = carbohydratesInput.Text;
            protein = proteinInput.Text;
            fat = fatInput.Text;
            sugar = sugarInput.Text;
            sodium = sodiumInput.Text;
            cholesterol = cholesterolInput.Text;

            if (IsValid())
            {

            }

            Toast.MakeText(this, "Food item saved successfully!", ToastLength.Short).Show();
        }
        private bool IsValid()
        {
            if (foodName != "" && calories != "" && carbohydrates != "" && protein != "" && fat != "" && sugar != "" && sodium != "" && cholesterol != "")
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        private bool IsAdmin()
        {
            // Replace with your actual admin check logic
            return true; // Assume always true for demonstration purposes
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
            Type page = selectedNav.SelectedNavigation_Admin(item);

            Intent i = new Intent(this, page);
            StartActivity(i);

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
        // ============ built-in template functions for drawer (code ends here) =======================
    }
}