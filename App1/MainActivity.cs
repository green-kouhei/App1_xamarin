using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            setContentView(R.layout.activity_main);
            Button button = (Button)FindViewById(R.id.button1);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }

        private void setContentView(object activity_main)
        {
            throw new NotImplementedException();
        }
    }
}

