using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Appnexus.Opensdk;
namespace SampleAndroid
{
    [Activity(Label = "SampleAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            BannerAdView bav = new BannerAdView(this);
            bav.PlacementID = "1326299";
            bav.SetAdSize(300, 50);
            bav.AutoRefreshInterval = 60;
            bav.ShouldServePSAs = true;
            bav.OpensNativeBrowser = true;


            //// Add the AdView to our layout 'n stuff.
            /// 
            /// th

            LinearLayout layout = (LinearLayout)FindViewById(Resource.Id.Root);
          
            LinearLayout a = new LinearLayout(this);
            a.Orientation = Orientation.Horizontal;
            a.AddView(bav);
            layout.AddView(a);



            //// Get our button from the layout resource,
            //// and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

