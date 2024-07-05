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
using AndroidX.Loader.Content;
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
using static Android.Graphics.Paint;
using static Java.Text.Normalizer;

namespace App1
{
    [Activity(Label = "DietDisplay", ScreenOrientation = ScreenOrientation.Portrait)]
    public class DietDisplay : AppCompatActivity//, NavigationView.IOnNavigationItemSelectedListener
    {
        DrawerNavigation selectedNav = new DrawerNavigation();
        DBClass db = new DBClass();
        JsonElement root;
        string email = Login.MyGlobals.Globalemail, selectedDiet;

        CardView lessug, hiprot, lessod, locarb, lofat, zerchol;
        TextView dietType;
        SearchView sv;
        float sugar, cholesterol, sodium, fat, protein, calorie_energy, carbohydrate;
        float portions = 100;

        Button btn1;
        private ListView lv, lv2;
        private ArrayList illness, foods, diets, dietsFilts;
        private ArrayAdapter _adapter2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.diet_display);

            /*
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
            */

            // Create your application here
            btn1 = FindViewById<Button>(Resource.Id.btn1);

            sv = FindViewById<SearchView>(Resource.Id.searchfood);
            dietType = FindViewById<TextView>(Resource.Id.dietType);

            selectedDiet = Intent.GetStringExtra("SelectedDiet");

            sv.QueryTextChange += sv_QueryTextChange;
            //food = FindViewById<TextView>(Resource.Id.foods);
            //lv = FindViewById<ListView>(Resource.Id.listview1);
            lv2 = FindViewById<ListView>(Resource.Id.listview2);

            //addIll();
            addFood();

            _adapter2 = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, foods);
            lv2.Adapter = _adapter2;

            lv2.ItemClick += lv2_ItemClick;
            btn1.Click += backEvent;



        }

        /*private void addIll()
        {
            illness = new ArrayList();
            diets = new ArrayList();
            dietsFilts = new ArrayList();

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
            }
            else if (illness.Contains("Cancer"))
            {
                diets.Add("Zero Cholesterol");
                diets.Add("Less Sodium");
            }

            else
            {
                diets.Add("Low Carb");
                diets.Add("High Protein");
                diets.Add("Low-Fat Content");
            }

            string recom = String.Join(",", diets);
            //food.Text = "Suggested diets for you: " + recom;// + illness.ToString();

        }*/
        private void sv_QueryTextChange(object sender, SearchView.QueryTextChangeEventArgs e)
        {
            _adapter2.Filter.InvokeFilter(e.NewText);
        }
        public void backEvent(object sender, EventArgs e)
        {
                Finish();
                Intent i = new Intent(this, typeof(SuggestFood));
                StartActivity(i);
        }
        private void lv2_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            string selectedFood = _adapter2.GetItem(e.Position).ToString();
            Intent i = new Intent(this, typeof(DisplayPage));

            i.PutExtra("SelectedFood", selectedFood);
            i.PutExtra("ActivityPage", "DietDisplay");
            i.PutExtra("SelectedDiet", selectedDiet);
            StartActivity(i);
        }
        private void addFood()
        {
            foods = new ArrayList();

            // Get food data from DB
            //root = db.RetrieveData("search_fooddata.php?");
            root = db.RetrieveDataAzure("SELECT food_data.food_id, food_data.food_name, nutrients.calorie_energy, nutrients.protein, nutrients.total_fat, nutrients.carbohydrate, nutrients.sugar, nutrients.sodium, nutrients.cholesterol FROM food_data INNER JOIN nutrients ON food_data.food_id = nutrients.food_id ORDER BY food_data.food_name ASC; ",null, "food_db");
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

                if (selectedDiet == "Sugar")
                {
                    if (((sugar / calorie_energy) * 100) <= 5)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                        dietType.Text = "Low sugar";

                    }
                }
                else if (selectedDiet == "Protein")
                {
                    if (protein >= 20)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                        dietType.Text = "High Protein";
                    }
                }
                else if (selectedDiet == "Sodium")
                {
                    if (sodium <= 5)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                        dietType.Text = "Less Sodium";
                    }
                }
                else if (selectedDiet == "Carbohydrates")
                {
                    if (carbohydrate <= 10)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                        dietType.Text = "Low-Carb";
                    }
                }
                else if (selectedDiet == "Fat")
                {
                    if (fat <= 3)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                        dietType.Text = "Low-Fat Content";
                    }
                }
                else if (selectedDiet == "Cholesterol")
                {
                    if (cholesterol <= 2)
                    {
                        foods.Add(u1.GetProperty("food_name").ToString());
                        dietType.Text = "Zero Cholesterol";
                    }
                }

            }
        }
        /*
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
        */
    }
}