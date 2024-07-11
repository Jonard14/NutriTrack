using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidX.Fragment.App;
using AndroidX.ViewPager.Widget;

namespace App1
{
    public class PagerAdapter : AndroidX.Fragment.App.FragmentStatePagerAdapter
    {
        private readonly Fragment[] fragments;

        public PagerAdapter(FragmentManager fm) : base(fm, BehaviorResumeOnlyCurrentFragment)
        {
            fragments = new Fragment[] {
                new NutritionFragment(),
                new FoodAdded()
            };
        }

        public override int Count => fragments.Length;

        public override Fragment GetItem(int position)
        {
            switch (position)
            {
                case 0:
                    return new NutritionFragment();
                case 1:
                    return new FoodAdded();
                default:
                    return null;
            }
        }
        public override int GetItemPosition(Java.Lang.Object obj)
        {
            return PositionNone; // This ensures that the fragments are recreated
        }
    }
}

