using Android.App;
using Android.Content;
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
    [Activity(Label = "Logs")]
    public class Logs : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DBClass db = new DBClass();
        JsonElement root;


        DrawerNavigation selectedNav = new DrawerNavigation();

        string searchemail, gender;
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
            history = new ArrayList();

            // Get food data from DB
            root = db.RetrieveData("search_trackerlog.php?");
            try
            {
                for (int i = 0; i < root.GetArrayLength(); i++)
                {
                    var u1 = root[i];
                    if (email == u1.GetProperty("email").ToString())
                    {
                        history.Add(u1.GetProperty("time_log").ToString() +
                                    "\nCalorie Count: " + u1.GetProperty("calorie_count").ToString() + " kcal" +
                                    "\nSugar Count: " + u1.GetProperty("sugar_count").ToString() + " g" +
                                    "\nProtein Count: " + u1.GetProperty("protein_count").ToString() + " g" +
                                    "\nFats Count: " + u1.GetProperty("fats_count").ToString() + " g" +
                                    "\nCarbohydrates Count: " + u1.GetProperty("carbohydrates_count").ToString() + " g" +
                                    "\nCholesterol Count: " + u1.GetProperty("cholesterol_count").ToString() + " mg" +
                                    "\nSodium Count: " + u1.GetProperty("sodium_count").ToString() + " mg");
                    }
                }
            }
            catch
            {
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