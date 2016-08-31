AppNexus Binding for Xamarin Android
===================

Based on and contains parts of [AppNexus mobile SDK for Android](https://github.com/appnexus/mobile-sdk-android)

----------


Usage
-------------

Include the Binding_AppnexusSdk project in your project as a reference. 

In your MainActivity.cs of a new Xamarin Android project. 


```C#
using Com.Appnexus.Opensdk;
```
Create a new BannerAdView and add it to the layout by modifying the OnCreate method. 

```C#
 protected override void OnCreate(Bundle bundle)
  {
      base.OnCreate(bundle);

      // Set our view from the "main" layout resource
      SetContentView(Resource.Layout.Main);
            
      //Create a new BannderAdView with a sample ad. 
      BannerAdView bav = new BannerAdView(this);
      bav.PlacementID = "1326299";
      bav.SetAdSize(300, 50);
      bav.AutoRefreshInterval = 60;
      bav.ShouldServePSAs = true;
      bav.OpensNativeBrowser = true;

      // Add the AdView to our layout

      LinearLayout layout = (LinearLayout)FindViewById(Resource.Id.Root);
          
      LinearLayout a = new LinearLayout(this);
      a.Orientation = Orientation.Horizontal;
      a.AddView(bav);
      layout.AddView(a);
  }
}
```
