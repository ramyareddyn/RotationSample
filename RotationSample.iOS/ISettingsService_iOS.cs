using System;
using Foundation;
using RotationSample.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(ISettingsService_iOS))]
namespace RotationSample.iOS
{
    public class ISettingsService_iOS : ISettingsService
    {
        public ISettingsService_iOS()
        {
        }


        public void ChangeOrientation(string mode)
        {
            // Need to rotate the device to the landscape mode.
            if (mode == "Landscape")
            {
                UIApplication.SharedApplication.SetStatusBarOrientation(UIInterfaceOrientation.LandscapeLeft, false);
                UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientation.LandscapeLeft), new NSString("orientation"));
                UINavigationController.AttemptRotationToDeviceOrientation();
            }
            else
            {
                UIApplication.SharedApplication.SetStatusBarOrientation(UIInterfaceOrientation.Portrait, false);
                UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientation.Portrait), new NSString("orientation"));
                UINavigationController.AttemptRotationToDeviceOrientation();
            }
        }
    }
}
