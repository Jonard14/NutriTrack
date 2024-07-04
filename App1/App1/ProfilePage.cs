using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Android.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Provider;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.Snackbar;
using System.Text.Json;
using AndroidX.AppCompat.App;
using Google.Android.Material.Navigation;
using Android.Content.PM;

namespace App1
{
    [Activity(Label = "Profile", ScreenOrientation = ScreenOrientation.Portrait)]
    public class ProfilePage : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DrawerNavigation selectedNav = new DrawerNavigation();
        DBClass db = new DBClass();
        JsonElement root;
        string email = Login.MyGlobals.Globalemail;

        private ImageView profilePicture;
        private TextView firstNameText;
        private TextView lastNameText;
        private TextView emailText;
        private TextView birthdayText;
        private TextView genderText;
        private TextView heightText;
        private TextView weightText;
        private TextView bmiText;
        private TextView illnessText;
        private Button updateProfileButton;
        private Button backToHomeButton;
        private double height = 1.75;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.profile_page_drawer);

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

            // Initialize UI components
            firstNameText = FindViewById<TextView>(Resource.Id.txtV_ProfileFirstName);
            lastNameText = FindViewById<TextView>(Resource.Id.txtV_ProfileLastName);
            emailText = FindViewById<TextView>(Resource.Id.txtV_ProfileEmail);
            birthdayText = FindViewById<TextView>(Resource.Id.txtV_ProfileBirthday);
            genderText = FindViewById<TextView>(Resource.Id.txtV_ProfileGender);
            heightText = FindViewById<TextView>(Resource.Id.txtV_ProfileHeight);
            weightText = FindViewById<TextView>(Resource.Id.txtV_ProfileWeight);
            bmiText = FindViewById<TextView>(Resource.Id.txtV_ProfileBMI);
            illnessText = FindViewById<TextView>(Resource.Id.txtV_ProfileIllness);
            updateProfileButton = FindViewById<Button>(Resource.Id.btn_UpdateProfile);
            //backToHomeButton = FindViewById<Button>(Resource.Id.btn_BackToHome);

            // Set up click events
            updateProfileButton.Click += UpdateProfileButton_Click;
            //backToHomeButton.Click += BackToHomeButton_Click;

        }

        private void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string weightStr = weightText.Text;
                if (double.TryParse(weightStr, out double weight))
                {
                    double bmi = weight / (height * height);
                    bmiText.Text = $"Your BMI: {bmi:F2}";
                }
                else
                {
                    bmiText.Text = "Please enter a valid weight";
                }
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrWhiteSpace(firstNameText.Text))
            {
                firstNameText.Error = "First name is required";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                lastNameText.Error = "Last name is required";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(emailText.Text)) //|| !Regex.IsMatch(emailText.Text, emailPattern))
            {
                emailText.Error = "Valid email is required";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(birthdayText.Text))
            {
                birthdayText.Error = "Birthday is required";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(genderText.Text))
            {
                genderText.Error = "Gender is required";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(heightText.Text) || !double.TryParse(heightText.Text, out _))
            {
                heightText.Error = "Valid height is required";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(weightText.Text) || !double.TryParse(weightText.Text, out _))
            {
                weightText.Error = "Valid weight is required";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(illnessText.Text))
            {
                illnessText.Error = "Illness information is required";
                isValid = false;
            }

            return isValid;
        }

        private void BackToHomeButton_Click(object sender, EventArgs e)
        {
            // Implement navigation back to home
            Finish();
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
                OpenWebLink("https://www.canva.com/design/DAF-j62aMQg/G1IK-EeQPP3ZUL7q-K_qyg/edit?utm_content=DAF-j62aMQg&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton");
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
        private void OpenWebLink(string url)
        {
            Intent intent = new Intent(Intent.ActionView, Android.Net.Uri.Parse(url));
            StartActivity(intent);
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