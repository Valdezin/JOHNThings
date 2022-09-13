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
    [Activity(Label = "Device Info")]
    public class debug : AppCompatActivity
    {
        private TextView textView1, textView2, textView3, textView4, textView5, textView6;
        private ImageView imageView1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.device_info);
            FindView();

            var device = DeviceInfo.Model;
            var manufacturer = DeviceInfo.Manufacturer;
            var deviceName = DeviceInfo.Name;
            var version = DeviceInfo.VersionString;
            var platform = DeviceInfo.Platform;
            var idiom = DeviceInfo.Idiom;
            var deviceType = DeviceInfo.DeviceType;


            var androidID = Android.Provider.Settings.Secure.GetString(Android.App.Application.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId);

            textView1.Text = $"Manufacturer: {manufacturer}";
            textView2.Text = $"Device Model: {device}";
            textView3.Text = $"Android Version: {version}";
            textView4.Text = $"OS: {platform}";
            textView5.Text = $"Android ID: {androidID}";
            
            if (manufacturer.Contains("samsung", StringComparison.OrdinalIgnoreCase))
                { imageView1.SetImageResource(Resource.Drawable.brand_samsung);}
            else if (manufacturer.Contains("xiaomi", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_xiaomi); }
            else if (manufacturer.Contains("google", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_google); }
            else if (manufacturer.Contains("vivo", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_vivo); }
            else if (manufacturer.Contains("huawei", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_huawei); }
            else if (manufacturer.Contains("cherry", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_cherry); }
            else if (manufacturer.Contains("oppo", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_oppo); }
            else if (manufacturer.Contains("poco", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_poco); }
            else if (manufacturer.Contains("realme", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_realme); }
            else if (manufacturer.Contains("asus", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_asus); }
            else if (manufacturer.Contains("lenovo", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_lenovo); }
            else if (manufacturer.Contains("zte", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_zte); }
            else if (manufacturer.Contains("oneplus", StringComparison.OrdinalIgnoreCase))
            { imageView1.SetImageResource(Resource.Drawable.brand_oneplus); }
            
        }


        private void FindView()
        {
            textView1 = FindViewById<TextView>(Resource.Id.textView1);
            textView2 = FindViewById<TextView>(Resource.Id.textView2);
            textView3 = FindViewById<TextView>(Resource.Id.textView3);
            textView4 = FindViewById<TextView>(Resource.Id.textView4);
            textView5 = FindViewById<TextView>(Resource.Id.textView5);
            textView6 = FindViewById<TextView>(Resource.Id.textView5);
            imageView1 = FindViewById<ImageView>(Resource.Id.imageView1);
        }
    }
}