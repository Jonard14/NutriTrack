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
    public class ProfilePage : Activity, NavigationView.IOnNavigationItemSelectedListener
    {
        DrawerNavigation selectedNav = new DrawerNavigation();
        DBClass db = new DBClass();
        JsonElement root;
        string email = Login.MyGlobals.Globalemail;

        private const int PickImageRequest = 1;
        private ImageView profilePicture;
        private TextView weightInput;
        private TextView bmiDisplay;
        private double height = 1.75; // User's height in meters (example value)

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.profile_page_drawer);

            // Drawer Layout
            AndroidX.AppCompat.Widget.Toolbar toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);

            //FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            //fab.Click += FabOnClick;

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

            // Create your application here
            profilePicture = FindViewById<ImageView>(Resource.Id.profile_picture);
            weightInput = FindViewById<TextView>(Resource.Id.weight_input);
            bmiDisplay = FindViewById<TextView>(Resource.Id.BMI);
            var changePictureButton = FindViewById<Button>(Resource.Id.change_picture_button);
            var updateButton1 = FindViewById<Button>(Resource.Id.update_button1);
            var updateButton2 = FindViewById<Button>(Resource.Id.update_button2);
            var updateButton3 = FindViewById<Button>(Resource.Id.update_button3);

            changePictureButton.Click += ChangePictureButton_Click;
            updateButton2.Click += UpdateButton_Click;
        }

        private void ChangePictureButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent();
            intent.SetType("image/*");
            intent.SetAction(Intent.ActionGetContent);
            StartActivityForResult(Intent.CreateChooser(intent, "Select Picture"), PickImageRequest);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == PickImageRequest && resultCode == Result.Ok && data != null && data.Data != null)
            {
                Android.Net.Uri uri = data.Data;
                try
                {
                    Bitmap bitmap = MediaStore.Images.Media.GetBitmap(ContentResolver, uri);
                    profilePicture.SetImageBitmap(bitmap);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string weightStr = weightInput.Text;
            if (!string.IsNullOrEmpty(weightStr))
            {
                if (double.TryParse(weightStr, out double weight))
                {
                    double bmi = weight / (height * height);
                    bmiDisplay.Text = $"Your BMI: {bmi:F2}";
                }
                else
                {
                    bmiDisplay.Text = "Please enter a valid weight";
                }
            }
            else
            {
                bmiDisplay.Text = "Please enter your weight";
            }
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