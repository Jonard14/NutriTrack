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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.homepage);


            lv = FindViewById<ListView>(Resource.Id.listview1);
            sv = FindViewById<SearchView>(Resource.Id.searchfood);

            addData();

            _adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, foods);
            lv.Adapter = _adapter;

            sv.QueryTextChange += sv_QueryTextChange;
            lv.ItemClick += lv_ItemClick;
           
        }

        private void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, _adapter.GetItem(e.Position).ToString(),ToastLength.Short).Show();
        }

        private void sv_QueryTextChange(object sender, SearchView.QueryTextChangeEventArgs e)
        {
            _adapter.Filter.InvokeFilter(e.NewText);
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

    }
}