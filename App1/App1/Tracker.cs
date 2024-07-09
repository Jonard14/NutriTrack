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
using AndroidX.ViewPager.Widget;
using Google.Android.Material.Navigation;
using Google.Android.Material.Snackbar;
using AndroidX.Fragment.App;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using static Android.Provider.DocumentsContract;

namespace App1
{
    [Activity(Label = "Tracker", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Tracker : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        private ViewPager viewPager;
        private PagerAdapter adapter;
        private Button buttonNutrition, buttonFoodAdded;

        DrawerNavigation selectedNav = new DrawerNavigation();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.tracker_drawer);

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

            
            viewPager = FindViewById<ViewPager>(Resource.Id.view_pager);
            buttonNutrition = FindViewById<Button>(Resource.Id.button_nutrition);
            buttonFoodAdded = FindViewById<Button>(Resource.Id.button_food_added);

            SetupViewPager(viewPager);

            buttonNutrition.Click += (sender, e) => viewPager.SetCurrentItem(0, true);
            buttonFoodAdded.Click += (sender, e) => viewPager.SetCurrentItem(1, true);

            viewPager.PageSelected += (sender, e) => {
                buttonNutrition.Enabled = e.Position != 0;
                buttonFoodAdded.Enabled = e.Position != 1;
            };

        }
        private void SetupViewPager(ViewPager viewPager)
        {
            adapter = new PagerAdapter(SupportFragmentManager);
            viewPager.Adapter = adapter;
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
                // Remove the token
                AuthService.RemoveAuthToken();

                // Clear global data
                TempDataService.ClearGlobalData();
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