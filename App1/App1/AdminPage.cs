using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    [Activity(Label = "Admin", ScreenOrientation = ScreenOrientation.Portrait)]
    public class AdminPage : Activity
    {
        private EditText foodNameInput, caloriesInput, carbohydratesInput, proteinInput, fatInput, sugarInput, sodiumInput, cholesterolInput;
        private Button submitButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            if (!IsAdmin())
            {
                Toast.MakeText(this, "Access denied!", ToastLength.Short).Show();
                Finish();
                return;
            }

            SetContentView(Resource.Layout.admin);
            /*
            
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
            */

            // Set submit button click event
            submitButton.Click += OnSubmitButtonClick;
            
        }

        private void OnSubmitButtonClick(object sender, EventArgs e)
        {
            string foodName = foodNameInput.Text;
            string calories = caloriesInput.Text;
            string carbohydrates = carbohydratesInput.Text;
            string protein = proteinInput.Text;
            string fat = fatInput.Text;
            string sugar = sugarInput.Text;
            string sodium = sodiumInput.Text;
            string cholesterol = cholesterolInput.Text;

            // Add code to save data to database
            // ...

            Toast.MakeText(this, "Food item saved successfully!", ToastLength.Short).Show();
        }

        private bool IsAdmin()
        {
            // Replace with your actual admin check logic
            return true; // Assume always true for demonstration purposes
        }
    }
}