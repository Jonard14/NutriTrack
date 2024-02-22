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

            int id = item.ItemId;

            if (id == Resource.Id.home_btn)
            {
                return typeof(HomePage);
            }
            else if (id == Resource.Id.tracker_btn)
            {
                return typeof(Tracker);
            }
            else if (id == Resource.Id.logout_btn)
            {
                return typeof(MainActivity);
            }
            return null;
        }
    }
}