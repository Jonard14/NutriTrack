using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Navigation;
using Google.Android.Material.Snackbar;
using Java.Lang.Annotation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace App1
{
    [Activity(Label = "SuggestFood")]
    public class SuggestFood : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DrawerNavigation selectedNav = new DrawerNavigation();
        DBClass db = new DBClass();
        JsonElement root;
        string email = Login.MyGlobals.Globalemail;

        float sugar, cholesterol, sodium, fat, protein;
        float portions = 100;


        private ListView lv, lv2;
        private ArrayList illness, foods;
        private ArrayAdapter _adapter, _adapter2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.suggest_drawer);


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

            lv = FindViewById<ListView>(Resource.Id.listview1);
            lv2 = FindViewById<ListView>(Resource.Id.listview2);

            addIll();
            addFood();

            _adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, illness);
            lv.Adapter = _adapter;

            _adapter2 = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem2, foods);
            lv2.Adapter = _adapter2;




        }
        private void addIll()
        {
            illness = new ArrayList();

            // Get food data from DB
            root = db.RetrieveData("search_user_illness.php?");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {

                var u1 = root[i];
                if (email == u1.GetProperty("email").ToString())
                {
                    illness.Add(u1.GetProperty("types").ToString());
                }

            }

        }
        private void addFood()
        {
            foods = new ArrayList();

            // Get food data from DB
            root = db.RetrieveData("search_fooddata.php?");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];

                sugar = float.Parse(u1.GetProperty("sugar").ToString()) * portions;
                cholesterol = float.Parse(u1.GetProperty("cholesterol").ToString()) * portions;
                sodium = float.Parse(u1.GetProperty("sodium").ToString()) * portions;
                fat = float.Parse(u1.GetProperty("total_fat").ToString()) * portions;
                protein = float.Parse(u1.GetProperty("protein").ToString()) * portions;

                /*
                sugar = Convert.ToDecimal(u1.GetProperty("sugar").ToString());
                cholesterol = Convert.ToDecimal(u1.GetProperty("cholesterol").ToString());
                sodium = Convert.ToDecimal(u1.GetProperty("sodium").ToString());
                fat = Convert.ToDecimal(u1.GetProperty("total_fat").ToString());
                protein = Convert.ToDecimal(u1.GetProperty("protein").ToString());
                */

                if (illness.Contains("DIABETES") || illness.Contains("HEART DISEASE") || illness.Contains("CANCER"))
                {
                    if (sugar < 5 && cholesterol < 100 && sodium < 5)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                    }
                }
                else
                {
                    if (protein >= 15 && protein <= 30)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                    }

                }
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