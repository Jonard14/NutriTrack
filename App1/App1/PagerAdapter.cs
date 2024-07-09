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

namespace App1
{
    public class PagerAdapter : FragmentPagerAdapter
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
            return fragments[position];
        }
    }
}

