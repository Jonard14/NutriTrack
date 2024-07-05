using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
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
using Java.Lang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using static Android.Provider.DocumentsContract;
using Exception = System.Exception;

namespace App1
{
    [Activity(Label = "History Logs", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Logs : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DBClass db = new DBClass();
        JsonElement root;


        DrawerNavigation selectedNav = new DrawerNavigation();

        string email = Login.MyGlobals.Globalemail, selected_bmonth;

        int selMonth = 01;

        Spinner bmonth;

        private ListView lv;
        private ArrayList history;
        private ArrayAdapter _adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.logs_drawer);

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

            history = new ArrayList();
            lv = FindViewById<ListView>(Resource.Id.listview1);

            bmonth = FindViewById<Spinner>(Resource.Id.spinner_birthmonth);
            selected_bmonth = bmonth.SelectedItem.ToString();
            bmonth.ItemSelected += bmonth_ItemSelected;

           

        }
        public void bmonth_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            selected_bmonth = bmonth.SelectedItem.ToString();
            retrieveTrackerLog();
            updateLog();
        }


        private void updateLog()
        {
            _adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, history);
            lv.Adapter = _adapter;
        }

        private void retrieveTrackerLog()
        {
            bool notempty = true;
            history = new ArrayList();

            // Get food data from DB
            //root = db.RetrieveData("search_trackerlog.php?");
            root = db.RetrieveDataAzure("SELECT * FROM tracker_log  ORDER BY time_log DESC;", null, "user_db");
            try
            {
                for (int i = 0; i < root.GetArrayLength(); i++)
                {
                    var u1 = root[i];
                    DateTime logDateTime = DateTime.ParseExact(u1.GetProperty("time_log").ToString(), "MM/dd/yyyy h:mm:ss tt", null);
                    string month = logDateTime.Month.ToString();
                    string conMon = convertMonth(month);

                    if (email == u1.GetProperty("email").ToString() && conMon == selected_bmonth)
                    {
                        history.Add(u1.GetProperty("time_log").ToString() +
                                    "\nCalorie Count: " + (float)System.Math.Round(float.Parse(u1.GetProperty("calorie_count").ToString()), 2) + " kcal" +
                                    "\nSugar Count: " + (float)System.Math.Round(float.Parse(u1.GetProperty("sugar_count").ToString()), 2) + " g" +
                                    "\nProtein Count: " + (float)System.Math.Round(float.Parse(u1.GetProperty("protein_count").ToString()), 2) + " g" +
                                    "\nFats Count: " + (float)System.Math.Round(float.Parse(u1.GetProperty("fats_count").ToString()), 2) + " g" +
                                    "\nCarbohydrates Count: " + (float)System.Math.Round(float.Parse(u1.GetProperty("carbohydrates_count").ToString()), 2) + " g" +
                                    "\nCholesterol Count: " + (float)System.Math.Round(float.Parse(u1.GetProperty("cholesterol_count").ToString()), 2) + " mg" +
                                    "\nSodium Count: " + (float)System.Math.Round(float.Parse(u1.GetProperty("sodium_count").ToString()), 2) + " mg");

                        notempty = false;
                    }
                }
                if (notempty)
                    history.Add("No logs available");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                history.Add("No logs available");

            }
            Console.WriteLine(root);
        }
        public string convertMonth(string data_bmonth)
        {
            switch (data_bmonth)
            {
                case "1": data_bmonth = "January"; break;
                case "2": data_bmonth = "February"; break;
                case "3": data_bmonth = "March"; break;
                case "4": data_bmonth = "April"; break;
                case "5": data_bmonth = "May"; break;
                case "6": data_bmonth = "June"; break;
                case "7": data_bmonth = "July"; break;
                case "8": data_bmonth = "August"; break;
                case "9": data_bmonth = "September"; break;
                case "10": data_bmonth = "October"; break;
                case "11": data_bmonth = "November"; break;
                case "12": data_bmonth = "December"; break;
            }
            return data_bmonth;
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