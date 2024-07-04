using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    /* Jonard note:
        This is where the value of selected item in a drawer
        To add more items in a drawer, 
            the file location is "Resources/menu/" 
            then find the file named "activity_main_drawer.xml"
    */

    public class DrawerNavigation
    {
        // User Account Side
        public Type SelectedNavigation(IMenuItem item)
        {
            //selected_drawer = item.TitleFormatted.ToString(); // stores title of category in string var

            switch (item.ItemId)
            {
                case Resource.Id.home_btn:
                    return typeof(HomePage);
                case Resource.Id.logout_btn:
                    return typeof(MainActivity);
                case Resource.Id.tracker_btn:
                    return typeof(Tracker);
                case Resource.Id.suggest_btn:
                    return typeof(SuggestFood);
                case Resource.Id.prof_btn:
                    return typeof(ProfilePage);
                case Resource.Id.logs_btn:
                    return typeof(Logs);
            }

            return null;
        }

        // Admin Account Side
        public Type SelectedNavigation_Admin(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.logout_btn:
                    return typeof(MainActivity);
                case Resource.Id.addfood_btn:
                    return typeof(Admin_AddFood);
                case Resource.Id.removefood_btn:
                    return typeof(Admin_AddFood);
            }

            return null;
        }
    }
}