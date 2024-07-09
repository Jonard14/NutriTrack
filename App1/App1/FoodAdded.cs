using Android.Animation;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using System;
using AndroidX.Fragment.App;
using System.Collections;
using System.Collections.Generic;
using static Android.Provider.DocumentsContract;

namespace App1
{
    public class FoodAdded : AndroidX.Fragment.App.Fragment
    {
        private ListView lv;
        private List<string> foods;
        private CustomAdapter _adapter;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Fragment specific initialization goes here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_food_added, container, false);

            lv = view.FindViewById<ListView>(Resource.Id.listview1);

            // Convert ArrayList to List<string>
            foods = new List<string>();
            foreach (var item in Login.MyGlobals.GlobalFoodList)
            {
                string[] parts = item.ToString().Split(',');
                if (parts.Length > 0)
                {
                    foods.Add(parts[0]); // Add only the food name
                }
            }

            _adapter = new CustomAdapter(Activity, foods, Login.MyGlobals.GlobalFoodList);
            lv.Adapter = _adapter;

            lv.ItemClick += (sender, e) =>
            {
                // Handle item click if needed
                Toast.MakeText(Activity, "Clicked: " + foods[e.Position], ToastLength.Short).Show();
            };

            return view;
        }

        private class CustomAdapter : BaseAdapter<string>
        {
            private readonly Activity context;
            private readonly List<string> items;
            private readonly ArrayList globalFoodList;

            public CustomAdapter(Activity context, List<string> items, ArrayList globalFoodList)
            {
                this.context = context;
                this.items = items;
                this.globalFoodList = globalFoodList;
            }

            public override long GetItemId(int position)
            {
                return position;
            }

            public override string this[int position] => items[position];

            public override int Count => items.Count;

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                var view = convertView ?? context.LayoutInflater.Inflate(Resource.Layout.list_item, null);
                var itemText = view.FindViewById<TextView>(Resource.Id.item_text);
                var itemButton = view.FindViewById<Button>(Resource.Id.item_button);

                itemText.Text = items[position];
                itemButton.Click += (sender, e) =>
                {
                    if (position < items.Count)
                    {
                        string foodDetails = globalFoodList[position].ToString();
                        string[] parts = foodDetails.Split(',');

                        if (parts.Length >= 8)
                        {
                            float calorie = float.Parse(parts[1]);
                            float sugar = float.Parse(parts[2]);
                            float fat = float.Parse(parts[3]);
                            float protein = float.Parse(parts[4]);
                            float cholesterol = float.Parse(parts[5]);
                            float carbohydrate = float.Parse(parts[6]);
                            float sodium = float.Parse(parts[7]);

                            // Subtract nutrient values from global totals
                            Login.MyGlobals.GlobalCalorie = (float)Math.Round(Login.MyGlobals.GlobalCalorie - calorie, 2);
                            Login.MyGlobals.GlobalSugar = (float)Math.Round(Login.MyGlobals.GlobalSugar - sugar, 2);
                            Login.MyGlobals.GlobalFat = (float)Math.Round(Login.MyGlobals.GlobalFat - fat, 2);
                            Login.MyGlobals.GlobalProtein = (float)Math.Round(Login.MyGlobals.GlobalProtein - protein, 2);
                            Login.MyGlobals.GlobalCholesterol = (float)Math.Round(Login.MyGlobals.GlobalCholesterol - cholesterol, 2);
                            Login.MyGlobals.GlobalCarbohyrates = (float)Math.Round(Login.MyGlobals.GlobalCarbohyrates - carbohydrate, 2);
                            Login.MyGlobals.GlobalSodium = (float)Math.Round(Login.MyGlobals.GlobalSodium - sodium, 2);

                            // Remove the item from both lists
                            items.RemoveAt(position);
                            globalFoodList.RemoveAt(position);
                            NotifyDataSetChanged();
                            TempDataService.SaveGlobalData();

                            Toast.MakeText(context, "Deleted " + parts[0], ToastLength.Short).Show();
                        }
                    }
                };

                return view;
            }
        }
    }
}
