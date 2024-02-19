using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{

    [Activity(Label = "HomePage")]
    public class HomePage : Activity
    {
        SearchView sv;
        ListView lv;
        ArrayList foods;
        ArrayAdapter _adapter;
        TextView nutriContentTV;
        Button addbtn, Tracker_btn;
        LinearLayout ll;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.homepage);


            lv = FindViewById<ListView>(Resource.Id.listview1);
            sv = FindViewById<SearchView>(Resource.Id.searchfood);

            ll = FindViewById<LinearLayout>(Resource.Id.linearLayout2);
            nutriContentTV = FindViewById<TextView>(Resource.Id.nutritionContentTV);
            addbtn = FindViewById<Button>(Resource.Id.myButton);

            addData();

            _adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, foods);
            lv.Adapter = _adapter;

            sv.QueryTextChange += sv_QueryTextChange;
            lv.ItemClick += lv_ItemClick;

            Tracker_btn = FindViewById<Button>(Resource.Id.btn_Tracker);
            Tracker_btn.Click += TrackerEvent;

        }

        private void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            string selectedFood = _adapter.GetItem(e.Position).ToString();
            updatenutritionalContent(selectedFood);
        }

        private void sv_QueryTextChange(object sender, SearchView.QueryTextChangeEventArgs e)
        {
            _adapter.Filter.InvokeFilter(e.NewText);

        }

        private void updatenutritionalContent(string food)
        {
            string nutritionalcontent = getNutritionalContent(food);
            nutriContentTV.Text = nutritionalcontent;
            ll.Visibility = ViewStates.Visible;
        }

        private string getNutritionalContent(string food)
        {
            if (food.Equals("Chicken Breast Fillet"))
            {
                return "Chicken Breast Fillet: \n Calories: 120 \n Protein: 25g \n Fat: 2g \n Carbohydrates: 0g";
            }

            return "Nutritional content not available";
        }
        private void addData()
        {
            foods = new ArrayList();
            foods.Add("Chicken Breast Fillet");
            foods.Add("Chicken Thigh");
            foods.Add("Fried Tofu");
            foods.Add("Bangus");
            foods.Add("Tilapia");
            foods.Add("Shrimp");
            foods.Add("Lean Beef");
            foods.Add("Pork Belly");
            foods.Add("Yogurt");
            foods.Add("Crab");
        }

        public void TrackerEvent(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(Tracker));
            StartActivity(i);
        }
    }
}