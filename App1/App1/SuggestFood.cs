using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
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
    [Activity(Label = "Suggest Food", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SuggestFood : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        DrawerNavigation selectedNav = new DrawerNavigation();
        DBClass db = new DBClass();
        JsonElement root;
        string email = Login.MyGlobals.Globalemail;

        CardView lessug, hiprot, lessod, locarb, lofat, zerchol;
        TextView food;
        float sugar, cholesterol, sodium, fat, protein, calorie_energy, carbohydrate;
        float portions = 100;


        private ListView lv, lv2;
        private ArrayList illness, foods, diets, dietsFilts;
        private ArrayAdapter _adapter2;
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

            food = FindViewById<TextView>(Resource.Id.foods);
            //lv = FindViewById<ListView>(Resource.Id.listview1);
            //lv2 = FindViewById<ListView>(Resource.Id.listview2);

            //CardView
            lessug = FindViewById<CardView>(Resource.Id.less_sugar_card);
            lessug.Click += (s, e) =>
            {
                // Handle Less Sugar card click
                ToDietDisplayPage("Sugar");
            };

            hiprot = FindViewById<CardView>(Resource.Id.high_prot_card);
            hiprot.Click += (s, e) =>
            {
                // Handle Less Sugar card click
                ToDietDisplayPage("Protein");
            };

            lessod = FindViewById<CardView>(Resource.Id.less_sod_card);
            lessod.Click += (s, e) =>
            {
                // Handle Less Sugar card click
                ToDietDisplayPage("Sodium");
            };

            locarb = FindViewById<CardView>(Resource.Id.low_carb_card);
            locarb.Click += (s, e) =>
            {
                // Handle Less Sugar card click
                ToDietDisplayPage("Carbohydrates");
            };

            lofat = FindViewById<CardView>(Resource.Id.low_fat_card);
            lofat.Click += (s, e) =>
            {
                // Handle Less Sugar card click
                ToDietDisplayPage("Fat");
            };

            zerchol = FindViewById<CardView>(Resource.Id.less_chol_card);
            zerchol.Click += (s, e) =>
            {
                // Handle Less Sugar card click
                ToDietDisplayPage("Cholesterol");
            };

            addIll();
            //addFood();

            //_adapter2 = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, foods);
            //lv2.Adapter = _adapter2;

            //lv2.ItemClick += lv2_ItemClick;
        }

        private void ToDietDisplayPage(string diet)
        {
            Intent i = new Intent(this, typeof(DietDisplay));

            i.PutExtra("SelectedDiet", diet);
            i.PutExtra("ActivityPage", "SuggestFood");
            StartActivity(i);
        }

        private void addIll()
        {
            illness = new ArrayList();
            diets = new ArrayList();
            dietsFilts = new ArrayList();

            // Get food data from DB
            /*root = db.RetrieveData("search_user_illness.php?");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {

                var u1 = root[i];
                if (email == u1.GetProperty("email").ToString())
                {
                    illness.Add(u1.GetProperty("types").ToString());
                }
            }*/

            root = db.RetrieveDataAzure("SELECT * FROM illnesses;", null, "user_db");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {

                var u1 = root[i];
                if (email == u1.GetProperty("email").ToString())
                {
                    illness.Add(u1.GetProperty("types").ToString());
                }

                //Recommended Diets
                if (illness.Contains("Heart Disease"))
                {
                    diets.Add("Less Sugar");
                    diets.Add("Zero Cholesterol");
                    diets.Add("Less Sodium");
                }
                else if (illness.Contains("Diabetes"))
                {
                    diets.Add("Less Sugar");
                    diets.Add("Zero Cholesterol");
                    diets.Add("High Protein");
                    diets.Add("Low Carb");
                }
                else if (illness.Contains("Cancer"))
                {
                    diets.Add("Zero Cholesterol");
                    diets.Add("Less Sodium");
                }

                else if (illness.Contains("Healthy"))
                {
                    diets.Add("Low Carb");
                    diets.Add("High Protein");
                    diets.Add("Low-Fat Content");
                }

                string recom = String.Join(", ", diets.ToArray().Distinct());
                food.Text = "Suggested foods for you: " + recom;// + illness.ToString();

            }
        
        /*private void lv2_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            string selectedFood = _adapter2.GetItem(e.Position).ToString();
            Intent i = new Intent(this, typeof(DisplayPage));

            i.PutExtra("SelectedFood", selectedFood);
            i.PutExtra("ActivityPage", "SuggestFood");
            StartActivity(i);
        }
        private void addFood()
        {
            foods = new ArrayList();

            // Get food data from DB
            root = db.RetrieveData("search_fooddata.php?");
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                var u1 = root[i];

                calorie_energy = float.Parse(u1.GetProperty("calorie_energy").ToString()) * portions;
                protein = float.Parse(u1.GetProperty("protein").ToString()) * portions;
                fat = float.Parse(u1.GetProperty("total_fat").ToString()) * portions;
                carbohydrate = float.Parse(u1.GetProperty("carbohydrate").ToString()) * portions;
                sugar = float.Parse(u1.GetProperty("sugar").ToString()) * portions;
                sodium = float.Parse(u1.GetProperty("sodium").ToString()) * portions;
                cholesterol = float.Parse(u1.GetProperty("cholesterol").ToString()) * portions;

                if (illness.Contains("Heart Disease"))
                {
                    if (sugar < 5 && cholesterol < 100 && (sodium / 1000) < 5)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                    }
                }
                else if (illness.Contains("Diabetes"))
                {
                    if (sugar < 5 && cholesterol < 100)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                    }
                }
                else if (illness.Contains("Cancer"))
                {
                    if ((sodium / 1000) < 5 && cholesterol < 100)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                    }
                }

                else
                {
                    if ((protein) >= 15 && (protein) <= 30)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                    }
                }



            }*/
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