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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using static Android.Provider.DocumentsContract;

namespace App1
{
    [Activity(Label = "Logs", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Logs : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DBClass db = new DBClass();
        JsonElement root;


        DrawerNavigation selectedNav = new DrawerNavigation();

        string email = Login.MyGlobals.Globalemail;

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
                    if (email == u1.GetProperty("email").ToString())
                    {
                        history.Add(u1.GetProperty("time_log").ToString() +
                                    "\nCalorie Count: " + (float)Math.Round(float.Parse(u1.GetProperty("calorie_count").ToString()), 2) + " kcal" +
                                    "\nSugar Count: " + (float)Math.Round(float.Parse(u1.GetProperty("sugar_count").ToString()), 2) + " g" +
                                    "\nProtein Count: " + (float)Math.Round(float.Parse(u1.GetProperty("protein_count").ToString()), 2) + " g" +
                                    "\nFats Count: " + (float)Math.Round(float.Parse(u1.GetProperty("fats_count").ToString()), 2) + " g" +
                                    "\nCarbohydrates Count: " + (float)Math.Round(float.Parse(u1.GetProperty("carbohydrates_count").ToString()), 2) + " g" +
                                    "\nCholesterol Count: " + (float)Math.Round(float.Parse(u1.GetProperty("cholesterol_count").ToString()), 2) + " mg" +
                                    "\nSodium Count: " + (float)Math.Round(float.Parse(u1.GetProperty("sodium_count").ToString()), 2) + " mg");

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