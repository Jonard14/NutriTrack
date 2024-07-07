using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using System.Linq;
using System.Text;

namespace App1
{
    public static class TempDataService
    {
        public static void SaveGlobalData()
        {
            Preferences.Set(nameof(Login.MyGlobals.Globalemail), Login.MyGlobals.Globalemail);
            Preferences.Set(nameof(Login.MyGlobals.GlobalCalorie), Login.MyGlobals.GlobalCalorie);
            Preferences.Set(nameof(Login.MyGlobals.GlobalSugar), Login.MyGlobals.GlobalSugar);
            Preferences.Set(nameof(Login.MyGlobals.GlobalFat), Login.MyGlobals.GlobalFat);
            Preferences.Set(nameof(Login.MyGlobals.GlobalProtein), Login.MyGlobals.GlobalProtein);
            Preferences.Set(nameof(Login.MyGlobals.GlobalCholesterol), Login.MyGlobals.GlobalCholesterol);
            Preferences.Set(nameof(Login.MyGlobals.GlobalCarbohyrates), Login.MyGlobals.GlobalCarbohyrates);
            Preferences.Set(nameof(Login.MyGlobals.GlobalSodium), Login.MyGlobals.GlobalSodium);
        }

        public static void LoadGlobalData()
        {
            Login.MyGlobals.Globalemail = Preferences.Get(nameof(Login.MyGlobals.Globalemail), string.Empty);
            Login.MyGlobals.GlobalCalorie = Preferences.Get(nameof(Login.MyGlobals.GlobalCalorie), 0f);
            Login.MyGlobals.GlobalSugar = Preferences.Get(nameof(Login.MyGlobals.GlobalSugar), 0f);
            Login.MyGlobals.GlobalFat = Preferences.Get(nameof(Login.MyGlobals.GlobalFat), 0f);
            Login.MyGlobals.GlobalProtein = Preferences.Get(nameof(Login.MyGlobals.GlobalProtein), 0f);
            Login.MyGlobals.GlobalCholesterol = Preferences.Get(nameof(Login.MyGlobals.GlobalCholesterol), 0f);
            Login.MyGlobals.GlobalCarbohyrates = Preferences.Get(nameof(Login.MyGlobals.GlobalCarbohyrates), 0f);
            Login.MyGlobals.GlobalSodium = Preferences.Get(nameof(Login.MyGlobals.GlobalSodium), 0f);
        }

        public static void ClearGlobalData()
        {
            Preferences.Remove(nameof(Login.MyGlobals.Globalemail));
            Preferences.Remove(nameof(Login.MyGlobals.GlobalCalorie));
            Preferences.Remove(nameof(Login.MyGlobals.GlobalSugar));
            Preferences.Remove(nameof(Login.MyGlobals.GlobalFat));
            Preferences.Remove(nameof(Login.MyGlobals.GlobalProtein));
            Preferences.Remove(nameof(Login.MyGlobals.GlobalCholesterol));
            Preferences.Remove(nameof(Login.MyGlobals.GlobalCarbohyrates));
            Preferences.Remove(nameof(Login.MyGlobals.GlobalSodium));
        }
    }
}