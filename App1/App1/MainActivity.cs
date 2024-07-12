using System;
using System.Text.Json;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Navigation;
using Google.Android.Material.Snackbar;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity//, NavigationView.IOnNavigationItemSelectedListener
    {
        Button btn_Login;
        TextView register;
        ProgressBar progressBar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_loading);

            // Show loading screen
            progressBar = FindViewById<ProgressBar>(Resource.Id.progressBar);
            progressBar.IndeterminateDrawable.SetColorFilter(Color.White, PorterDuff.Mode.SrcIn);
            progressBar.Visibility = ViewStates.Visible;

            // Load global data in the background
            new LoadDataAsyncTask(this).Execute();
        }

        private class LoadDataAsyncTask : AsyncTask<Java.Lang.Void, Java.Lang.Void, Java.Lang.Void>
        {
            private MainActivity activity;

            public LoadDataAsyncTask(MainActivity activity)
            {
                this.activity = activity;
            }

            protected override Java.Lang.Void RunInBackground(params Java.Lang.Void[] @params)
            {
                // Load global data
                if (GlobalData.rootFood.ValueKind == JsonValueKind.Undefined || GlobalData.rootFood.ValueKind == JsonValueKind.Null)
                {
                    // Load global data
                    DBClass db = new DBClass();
                    GlobalData.rootFood = db.RetrieveDataAzure("SELECT food_data.food_id, food_data.food_name, nutrients.calorie_energy, nutrients.protein, nutrients.total_fat, nutrients.carbohydrate, nutrients.sugar, nutrients.sodium, nutrients.cholesterol FROM food_data INNER JOIN nutrients ON food_data.food_id = nutrients.food_id ORDER BY food_data.food_name ASC; ", null, "food_db");
                }
                return null;
            }

            protected override void OnPostExecute(Java.Lang.Void result)
            {
                base.OnPostExecute(result);

                // Check if user is authenticated
                string token = AuthService.GetAuthToken();
                if (token != null)
                {
                    TempDataService.LoadGlobalData();
                    // Redirect to HomePage screen
                    Intent intent = new Intent(activity, typeof(HomePage));
                    activity.StartActivity(intent);
                    activity.Finish();
                }
                else
                {
                    // Load the main content
                    activity.SetContentView(Resource.Layout.content_main);
                    activity.InitializeMainContent();
                }
            }
        }

        private void InitializeMainContent()
        {
            // Code starts here
            btn_Login = FindViewById<Button>(Resource.Id.btn_signup);
            btn_Login.Click += Login;
            TempDataService.LoadGlobalData();
            register = FindViewById<TextView>(Resource.Id.txtV_RegLink);
            register.PaintFlags = PaintFlags.UnderlineText;
            register.Click += RegLink;
        }

        public void Login(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Login));
            //i.PutExtra("Text", variable);
            StartActivity(i);
        }

        public void RegLink(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Register));
            StartActivity(i);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public static class GlobalData
        {
            public static JsonElement rootFood { get; set; }
        }
    }
}
