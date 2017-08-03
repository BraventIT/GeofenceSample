using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Geofence.Plugin;
using GeofenceSample.Helpers;
using UIKit;

namespace GeofenceSample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Xamarin.FormsGoogleMaps.Init("AIzaSyC3liF6nj89L58ycANqM_telHYMlNrl5vE");
            CrossGeofence.Initialize<CrossGeofenceListener>();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
