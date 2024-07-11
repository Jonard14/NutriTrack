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
                string[] parts = item.ToString().Split('@');
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
                var itemButton = view.FindViewById<ImageButton>(Resource.Id.item_button);

                itemText.Text = items[position];
                itemButton.Click += (sender, e) =>
                {
                    if (position < items.Count)
                    {
                        string foodDetails = globalFoodList[position].ToString();
                        string[] parts = foodDetails.Split('@');
                        string foodName = parts[0];

                        if (parts.Length == 8)
                        {
                            try
                            {
                                // Extract and parse each part, ensuring they are in the correct format
                                
                                if (float.TryParse(parts[1].Trim(), out float calorie) &&
                                    float.TryParse(parts[2].Trim(), out float sugar) &&
                                    float.TryParse(parts[3].Trim(), out float fat) &&
                                    float.TryParse(parts[4].Trim(), out float protein) &&
                                    float.TryParse(parts[5].Trim(), out float cholesterol) &&
                                    float.TryParse(parts[6].Trim(), out float carbohydrate) &&
                                    float.TryParse(parts[7].Trim(), out float sodium))
                                {
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
                                    //Login.MyGlobals.GlobalFoodList.RemoveAt(position);
                                    NotifyDataSetChanged();
                                    TempDataService.SaveGlobalData();

                                    Toast.MakeText(context, "Deleted " + foodName, ToastLength.Short).Show();
                                }
                                else
                                {
                                    // Provide detailed error information
                                    Toast.MakeText(context, $"Error parsing nutrient values. Check the format: {foodDetails}", ToastLength.Long).Show();
                                }
                            }
                            catch (Exception ex)
                            {
                                Toast.MakeText(context, "Unexpected error: " + ex.Message, ToastLength.Long).Show();
                            }
                        }
                        else
                        {
                            Toast.MakeText(context, "Invalid food details format: " + foodName, ToastLength.Long).Show();
                        }
                    }
                };

                return view;
            }
        }
    }
}
