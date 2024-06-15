
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


namespace App1
{
    [Activity(Label = "ProfilePage")]
    public class ProfilePage : Activity
    {
        DrawerNavigation selectedNav = new DrawerNavigation();
        DBClass db = new DBClass();
        JsonElement root;
        string email = Login.MyGlobals.Globalemail;

        private const int PickImageRequest = 1;
        private ImageView profilePicture;
        private EditText weightInput;
        private TextView bmiDisplay;
        private double height = 1.75; // User's height in meters (example value)

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.profile_page_drawer);

            profilePicture = FindViewById<ImageView>(Resource.Id.profile_picture);
            weightInput = FindViewById<EditText>(Resource.Id.weight_input);
            bmiDisplay = FindViewById<TextView>(Resource.Id.bmi_display);
            var changePictureButton = FindViewById<Button>(Resource.Id.change_picture_button);
            var updateButton = FindViewById<Button>(Resource.Id.update_button);

            changePictureButton.Click += ChangePictureButton_Click;
            updateButton.Click += UpdateButton_Click;
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
                Uri uri = data.Data;
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