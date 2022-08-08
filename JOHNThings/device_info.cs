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
using JOHNThings;
using AndroidX.AppCompat.App;

namespace JOHNThings.Properties
{
    [Activity(Label = "debug")]
    public class debug : AppCompatActivity
    {
        private TextView textView1, textView2, textView3, textView4, textView5, textView6;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.device_info);
            FindView();
            // Device Model (SMG-950U, iPhone10,6)
            var device = DeviceInfo.Model;

            // Manufacturer (Samsung)
            var manufacturer = DeviceInfo.Manufacturer;

            // Device Name (Motz's iPhone)
            var deviceName = DeviceInfo.Name;

            // Operating System Version Number (7.0)
            var version = DeviceInfo.VersionString;

            // Platform (Android)
            var platform = DeviceInfo.Platform;

            // Idiom (Phone)
            var idiom = DeviceInfo.Idiom;

            // Device Type (Physical)
            var deviceType = DeviceInfo.DeviceType;


            var androidID = Android.Provider.Settings.Secure.GetString(Android.App.Application.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId);


            textView1.Text = $"Manufacturer :{manufacturer}";
            textView2.Text = $"Device Model :{device}";
            textView3.Text = $"Android Version :{version}";
            textView4.Text = $"OS: {platform}";
            textView5.Text = $"Android ID: {androidID}";

        }

        private void FindView()
        {
            textView1 = FindViewById<TextView>(Resource.Id.textView1);
            textView2 = FindViewById<TextView>(Resource.Id.textView2);
            textView3 = FindViewById<TextView>(Resource.Id.textView3);
            textView4 = FindViewById<TextView>(Resource.Id.textView4);
            textView5 = FindViewById<TextView>(Resource.Id.textView5);
            textView6 = FindViewById<TextView>(Resource.Id.textView5);
        }
    }
}