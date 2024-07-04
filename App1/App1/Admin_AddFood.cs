using Android.App;
using Android.Content;
using Android.Content.PM;
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

namespace App1
{
    [Activity(Label = "Admin - Add Food", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Admin_AddFood : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DBClass db = new DBClass();
        DrawerNavigation selectedNav = new DrawerNavigation();

        private EditText foodName, servingSize, calories, carbohydrates, protein, fat, sugar, sodium, cholesterol;
        private Button submitButton, resetButton;
        private bool bool_foodName, bool_servingSize, bool_calories, bool_carbohydrates, bool_protein, 
                     bool_fat, bool_sugar, bool_sodium, bool_cholesterol;


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
            foodName = FindViewById<EditText>(Resource.Id.edtTxt_FoodName);
            foodName.TextChanged += Input_TextChanged;
            servingSize = FindViewById<EditText>(Resource.Id.edtTxt_ServSize);
            servingSize.TextChanged += Input_TextChanged;
            calories = FindViewById<EditText>(Resource.Id.edtTxt_Calories);
            calories.TextChanged += Input_TextChanged;
            carbohydrates = FindViewById<EditText>(Resource.Id.edtTxt_Carbohydrates);
            carbohydrates.TextChanged += Input_TextChanged;
            protein = FindViewById<EditText>(Resource.Id.edtTxt_Protein);
            protein.TextChanged += Input_TextChanged;
            fat = FindViewById<EditText>(Resource.Id.edtTxt_Fat);
            fat.TextChanged += Input_TextChanged;
            sugar = FindViewById<EditText>(Resource.Id.edtTxt_Sugar);
            sugar.TextChanged += Input_TextChanged;
            sodium = FindViewById<EditText>(Resource.Id.edtTxt_Sodium);
            sodium.TextChanged += Input_TextChanged;
            cholesterol = FindViewById<EditText>(Resource.Id.edtTxt_Cholesterol);
            cholesterol.TextChanged += Input_TextChanged;

            // Reset Values
            resetButton = FindViewById<Button>(Resource.Id.reset_button);
            resetButton.Click += ResetButton_Click;
            // Set submit button click event
            submitButton = FindViewById<Button>(Resource.Id.submit_button);
            submitButton.Click += OnSubmitButtonClick;

        }

        // Dynamically show error prompt in input field
        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            EditText value = (EditText)sender;

            Dynamic_ValidationEvent(value);
        }
        private bool Dynamic_ValidationEvent(EditText value)
        {
            if (value.Text == "")
            {
                value.Error = "Input Empty!";
                return false;
            }
            return true;
        }

        private void OnSubmitButtonClick(object sender, EventArgs e)
        {
            bool_foodName = Dynamic_ValidationEvent(foodName);
            bool_servingSize = Dynamic_ValidationEvent(servingSize);
            bool_calories = Dynamic_ValidationEvent(calories);
            bool_carbohydrates = Dynamic_ValidationEvent(carbohydrates);
            bool_protein = Dynamic_ValidationEvent(protein);
            bool_fat = Dynamic_ValidationEvent(fat);
            bool_sugar = Dynamic_ValidationEvent(sugar);
            bool_sodium = Dynamic_ValidationEvent(sodium);
            bool_cholesterol= Dynamic_ValidationEvent(cholesterol);

            if (bool_foodName && bool_servingSize && bool_calories &&
                bool_carbohydrates && bool_protein && bool_fat &&
                bool_sugar && bool_sodium && bool_cholesterol)
            {
                db.InsertDataAzure("INSERT INTO food_data (food_name) VALUES ('"+ foodName.Text + "')",
                                   "food_db");
                db.InsertDataAzure("INSERT INTO nutrients (calorie_energy, protein, total_fat, carbohydrate, sugar, sodium, cholesterol) " +
                                   "VALUES (" +
                                   "'" + float.Parse(calories.Text) / float.Parse(servingSize.Text)+ "'," +
                                   "'" + float.Parse(protein.Text) / float.Parse(servingSize.Text) + "'," +
                                   "'" + float.Parse(fat.Text) / float.Parse(servingSize.Text) + "'," +
                                   "'" + float.Parse(carbohydrates.Text) / float.Parse(servingSize.Text) + "'," +
                                   "'" + float.Parse(sugar.Text) / float.Parse(servingSize.Text) + "'," +
                                   "'" + float.Parse(sodium.Text) / float.Parse(servingSize.Text) + "'," +
                                   "'" + float.Parse(cholesterol.Text) / float.Parse(servingSize.Text) + "'" +
                                   ")",
                                   "food_db");
                Toast.MakeText(this, "Food data saved successfully!", ToastLength.Short).Show();
            }
            else
                Toast.MakeText(this, "Unable to add food!", ToastLength.Short).Show();

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foodName.Text = "";
            servingSize.Text = "100";
            calories.Text = "";
            carbohydrates.Text = "";
            protein.Text = "";
            fat.Text = "";
            sugar.Text = "";
            sodium.Text = "";
            cholesterol.Text = "";
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