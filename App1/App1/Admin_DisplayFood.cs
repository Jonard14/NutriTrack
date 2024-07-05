using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using static Android.Provider.DocumentsContract;
using AlertDialog = Android.App.AlertDialog;

namespace App1
{
    [Activity(Label = "Admin - Display Food", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Admin_DisplayFood : AppCompatActivity//, NavigationView.IOnNavigationItemSelectedListener
    {
        string selectedFood;

        DBClass db = new DBClass();
        JsonElement root;
        string food_id, food_name;
        float calorie_energy, protein, total_fat, carbohydrate, sugar, sodium, cholesterol,
              calorie_compute, protein_compute, total_fat_compute, carbohydrate_compute, sugar_compute, sodium_compute, cholesterol_compute;

        private EditText et_foodName, et_servingSize, et_calories, et_carbohydrates, et_protein, et_fat, et_sugar, et_sodium, et_cholesterol;
        private Button back_btn, updateBtn, deleteBtn;
        private bool bool_foodName, bool_servingSize, bool_calories, bool_carbohydrates, bool_protein,
                     bool_fat, bool_sugar, bool_sodium, bool_cholesterol;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.admin_displayfood);

            // Create your application here
            et_foodName = FindViewById<EditText>(Resource.Id.edtTxt_FoodName);
            et_foodName.TextChanged += Input_TextChanged;
            et_servingSize = FindViewById<EditText>(Resource.Id.edtTxt_ServSize);
            et_servingSize.TextChanged += Input_TextChanged;
            et_calories = FindViewById<EditText>(Resource.Id.edtTxt_Calories);
            et_calories.TextChanged += Input_TextChanged;
            et_carbohydrates = FindViewById<EditText>(Resource.Id.edtTxt_Carbohydrates);
            et_carbohydrates.TextChanged += Input_TextChanged;
            et_protein = FindViewById<EditText>(Resource.Id.edtTxt_Protein);
            et_protein.TextChanged += Input_TextChanged;
            et_fat = FindViewById<EditText>(Resource.Id.edtTxt_Fat);
            et_fat.TextChanged += Input_TextChanged;
            et_sugar = FindViewById<EditText>(Resource.Id.edtTxt_Sugar);
            et_sugar.TextChanged += Input_TextChanged;
            et_sodium = FindViewById<EditText>(Resource.Id.edtTxt_Sodium);
            et_sodium.TextChanged += Input_TextChanged;
            et_cholesterol = FindViewById<EditText>(Resource.Id.edtTxt_Cholesterol);
            et_cholesterol.TextChanged += Input_TextChanged;

            // Back
            back_btn = FindViewById<Button>(Resource.Id.btn_Back);
            back_btn.Click += Back_btn_Click; ;
            // Update Data
            updateBtn = FindViewById<Button>(Resource.Id.update_button);
            updateBtn.Click += UpdateBtn_Click;
            // Delete Data
            deleteBtn = FindViewById<Button>(Resource.Id.delete_button);
            deleteBtn.Click += DeleteBtn_Click;

            selectedFood = Intent.GetStringExtra("SelectedFood");
            et_foodName.Text = selectedFood;
            retrieveData(selectedFood);
            updateUI();
        }

        // Back button
        private void Back_btn_Click(object sender, EventArgs e)
        {
            Finish();
            Intent i = new Intent(this, typeof(Admin_EditDelFoodList));
            StartActivity(i);
        }

        // Load data
        private void retrieveData(string selectedFood)
        {
            root = db.RetrieveDataAzure("SELECT food_data.food_id, food_data.food_name, nutrients.calorie_energy, nutrients.protein, nutrients.total_fat, nutrients.carbohydrate, nutrients.sugar, nutrients.sodium, nutrients.cholesterol FROM food_data INNER JOIN nutrients ON food_data.food_id = nutrients.food_id ORDER BY food_data.food_name ASC; ", null, "food_db");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];
                //food_id = u1.GetProperty("food_id").ToString();
                //food_name = u1.GetProperty("food_name").ToString();
                string tmpfood_name = u1.GetProperty("food_name").ToString();

                if (selectedFood.Equals(tmpfood_name))
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
            calorie_compute = calorie_energy * float.Parse(et_servingSize.Text);
            protein_compute = protein * float.Parse(et_servingSize.Text);
            total_fat_compute = total_fat * float.Parse(et_servingSize.Text);
            carbohydrate_compute = carbohydrate * float.Parse(et_servingSize.Text);
            sugar_compute = sugar * float.Parse(et_servingSize.Text);
            sodium_compute = sodium * float.Parse(et_servingSize.Text);
            cholesterol_compute = cholesterol * float.Parse(et_servingSize.Text);

            et_calories.Text = calorie_compute.ToString();
            et_carbohydrates.Text = carbohydrate_compute.ToString();
            et_protein.Text = protein_compute.ToString();
            et_fat.Text = total_fat_compute.ToString();
            et_sugar.Text = sugar_compute.ToString();
            et_sodium.Text = sodium_compute.ToString();
            et_cholesterol.Text = cholesterol_compute.ToString();
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

        // Update Data
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            bool_foodName = Dynamic_ValidationEvent(et_foodName);
            bool_servingSize = Dynamic_ValidationEvent(et_servingSize);
            bool_calories = Dynamic_ValidationEvent(et_calories);
            bool_carbohydrates = Dynamic_ValidationEvent(et_carbohydrates);
            bool_protein = Dynamic_ValidationEvent(et_protein);
            bool_fat = Dynamic_ValidationEvent(et_fat);
            bool_sugar = Dynamic_ValidationEvent(et_sugar);
            bool_sodium = Dynamic_ValidationEvent(et_sodium);
            bool_cholesterol = Dynamic_ValidationEvent(et_cholesterol);

            if (bool_foodName && bool_servingSize && bool_calories &&
                bool_carbohydrates && bool_protein && bool_fat &&
                bool_sugar && bool_sodium && bool_cholesterol)
            {
                
                db.InsertDataAzure("UPDATE nutrients SET " +
                                   "calorie_energy='" + float.Parse(et_calories.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "protein='" + float.Parse(et_protein.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "total_fat='" + float.Parse(et_fat.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "carbohydrate='" + float.Parse(et_carbohydrates.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "sugar='" + float.Parse(et_sugar.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "sodium='" + float.Parse(et_sodium.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "cholesterol='" + float.Parse(et_cholesterol.Text) / float.Parse(et_servingSize.Text) + "'" +
                                   " WHERE food_id='"+ food_id +"'",
                                   "food_db");
                
                /*
                db.InsertDataAzure("UPDATE n SET " +
                                   "n.calorie_energy='" + float.Parse(et_calories.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "n.protein='" + float.Parse(et_protein.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "n.total_fat='" + float.Parse(et_fat.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "n.carbohydrate='" + float.Parse(et_carbohydrates.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "n.sugar='" + float.Parse(et_sugar.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "n.sodium='" + float.Parse(et_sodium.Text) / float.Parse(et_servingSize.Text) + "'," +
                                   "n.cholesterol='" + float.Parse(et_cholesterol.Text) / float.Parse(et_servingSize.Text) + "'" +
                                   "FROM nutrients n JOIN food_data f ON n.food_id = f.food_id" +
                                   " WHERE food_name='" + selectedFood + "'",
                                   "food_db");
                */
                Toast.MakeText(this, "Food updated successfully!", ToastLength.Short).Show();
            }
            else
                Toast.MakeText(this, "Unable to update food!", ToastLength.Short).Show();

        }


        // Delete Data
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Create 
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.SetTitle("Delete");
            builder.SetMessage("Are you sure you want to delete "+ selectedFood +"?");

            builder.SetPositiveButton("Yes", (sender, args) =>
            {
                // Handle Yes button click

                // Perform Deletion
                db.InsertDataAzure("DELETE FROM nutrients WHERE food_id='"+ food_id +"'",
                                   "food_db");
                db.InsertDataAzure("DELETE FROM food_data WHERE food_id='" + food_id + "'",
                                   "food_db");

                Toast.MakeText(this, "Food Deleted Successfully!", ToastLength.Short).Show();

                // Returns to EditDelFoodList Activity
                Intent i = new Intent(this, typeof(Admin_EditDelFoodList));
                StartActivity(i);
            });

            builder.SetNegativeButton("No", (sender, args) =>
            {
                // Handle No button click
            });

            AlertDialog dialog = builder.Create();
            dialog.Show();
        }
    }
}