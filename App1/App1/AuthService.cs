using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace App1
{
    public static class AuthService
    {
        public static void SaveAuthToken(string token)
        {
            SecureStorage.SetAsync("auth_token", token).Wait();
        }

        public static string GetAuthToken()
        {
            try
            {
                return SecureStorage.GetAsync("auth_token").Result;
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                return null;
            }
        }

        public static void RemoveAuthToken()
        {
            SecureStorage.Remove("auth_token");
        }
    }
}