using Android.Animation;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.Hardware.Lights;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Views.Animations;
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
    [Activity(Label = "Profile", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class ProfilePage : AppCompatActivity
    {
        DBClass db = new DBClass();
        string email = Login.MyGlobals.Globalemail;

        private TextView firstNameText;
        private TextView lastNameText;
        private EditText emailEditText;
        private EditText birthdayEditText;
        private EditText genderEditText;
        private EditText heightEditText;
        private EditText weightEditText;
        private EditText bmiEditText;
        private EditText illnessEditText;
        private Button updateProfileButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.profile_page_drawer);

            // Initialize UI components from XML layout
            firstNameText = FindViewById<TextView>(Resource.Id.txtV_ProfileFirstName);
            lastNameText = FindViewById<TextView>(Resource.Id.txtV_ProfileLastName);
            emailEditText = FindViewById<EditText>(Resource.Id.edtTxt_Email);
            birthdayEditText = FindViewById<EditText>(Resource.Id.edtTxt_Birthday);
            genderEditText = FindViewById<EditText>(Resource.Id.edtTxt_Gender);
            heightEditText = FindViewById<EditText>(Resource.Id.edtTxt_Height);
            weightEditText = FindViewById<EditText>(Resource.Id.edtTxt_Weight);
            bmiEditText = FindViewById<EditText>(Resource.Id.edtTxt_BMI);
            illnessEditText = FindViewById<EditText>(Resource.Id.edtTxt_Illness);
            updateProfileButton = FindViewById<Button>(Resource.Id.btn_UpdateProfile);

            // Fetch and display user profile data
            FetchProfileData();

            // Set click listener for the update button
            updateProfileButton.Click += UpdateProfileButton_Click;
        }

        private void FetchProfileData()
        {
            var userProfile = db.GetUserProfile(email);

            if (userProfile != null)
            {
                firstNameText.Text = userProfile.FirstName;
                lastNameText.Text = userProfile.LastName;
                emailEditText.Text = userProfile.Email;
                birthdayEditText.Text = userProfile.Birthday;
                genderEditText.Text = userProfile.Gender;
                heightEditText.Text = userProfile.Height.ToString();
                weightEditText.Text = userProfile.Weight.ToString();
                bmiEditText.Text = userProfile.BMI.ToString();
                illnessEditText.Text = userProfile.Illness;
            }
        }

        private void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                // Update profile data in database
                bool success = UpdateUserProfile();

                if (success)
                {
                    Snackbar.Make(updateProfileButton, "Profile updated successfully", Snackbar.LengthShort)
                            .Show();
                }
                else
                {
                    Snackbar.Make(updateProfileButton, "Failed to update profile", Snackbar.LengthShort)
                            .Show();
                }
            }
        }

        private bool UpdateUserProfile()
        {
            var updatedProfile = new UserProfile
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Email = emailEditText.Text,
                Birthday = birthdayEditText.Text,
                Gender = genderEditText.Text,
                Height = double.Parse(heightEditText.Text),
                Weight = double.Parse(weightEditText.Text),
                BMI = CalculateBMI(double.Parse(weightEditText.Text), double.Parse(heightEditText.Text)),
                Illness = illnessEditText.Text
            };

            // Update profile in database
            return db.UpdateUserProfile(email, updatedProfile);
        }

        private double CalculateBMI(double weight, double height)
        {
            // Calculate BMI
            return weight / (height * height);
        }

        private bool ValidateInputs()
        {
            // Implement your validation logic here
            bool isValid = true;
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

            if (string.IsNullOrWhiteSpace(emailEditText.Text))
            {
                emailEditText.Error = "Email is required";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(birthdayEditText.Text))
            {
                birthdayEditText.Error = "Birthday is required";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(genderEditText.Text))
            {
                genderEditText.Error = "Gender is required";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(heightEditText.Text) || !double.TryParse(heightEditText.Text, out _))
            {
                heightEditText.Error = "Valid height is required";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(weightEditText.Text) || !double.TryParse(weightEditText.Text, out _))
            {
                weightEditText.Error = "Valid weight is required";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(illnessEditText.Text))
            {
                illnessEditText.Error = "Illness information is required";
                isValid = false;
            }

            return isValid;
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

            if (page == typeof(MainActivity))
            {
                FinishAffinity();
                Intent i = new Intent(this, page);
                StartActivity(i);

            }
            else
            {


                Intent i = new Intent(this, page);
                StartActivity(i);

                DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
                drawer.CloseDrawer(GravityCompat.Start);
            }

            return true;
        }
        // ============ built-in template functions for drawer (code ends here) =======================


    }

}