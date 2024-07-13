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
        public Type SelectedNavigation(IMenuItem item)
        {
            //selected_drawer = item.TitleFormatted.ToString(); // stores title of category in string var

            switch (item.ItemId)
            {
                case Resource.Id.logout_btn:
                    return typeof(MainActivity);

                // User Account Side
                case Resource.Id.home_btn:
                    return typeof(HomePage);
                case Resource.Id.tracker_btn:
                    return typeof(Tracker);
                case Resource.Id.suggest_btn:
                    return typeof(SuggestFood);
                case Resource.Id.prof_btn:
                    return typeof(ProfilePage);
                case Resource.Id.logs_btn:
                    return typeof(Logs);

                // Admin Account Side
                /* Note: This will not display to User side because
                 it was set the drawers from all "_drawer.xml" to call
                only "activity_main_drawer.xml" to display those items above.
                Then, for the admin side are the same but called to
                "admin_drawer.xml" to display only the items below
                */
                case Resource.Id.addfood_btn:
                    return typeof(Admin_AddFood);
                case Resource.Id.edtdelfood_btn:
                    return typeof(Admin_EditDelFoodList);
            }

            return typeof(MainActivity);
            /*Changed from null by kicked out to Entry Page jas for 
              failsafe cause the app will crash instead if set to null
             */
        }
    }
}