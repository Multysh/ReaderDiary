﻿namespace ReaderDiary.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;
    using ReaderDiary.Droid.Utils;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    [Activity(Label = "ReaderDiary", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            LoadApplication(new App(new Logger()));
        }
    }
}

