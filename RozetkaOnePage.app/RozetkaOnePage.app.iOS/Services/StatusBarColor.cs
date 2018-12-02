using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using RozetkaOnePage.app.Services;
using UIKit;
using Xamarin.Forms;

namespace RozetkaOnePage.app.iOS.Services
{
    class StatusBarColor : IStatusBarColor
    {
        public void SetColor(string rgbColor)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);
                GetCurrentViewController().SetNeedsStatusBarAppearanceUpdate();
            });

            UIViewController GetCurrentViewController()
            {
                var window = UIApplication.SharedApplication.KeyWindow;
                var vc = window.RootViewController;
                while (vc.PresentedViewController != null)
                    vc = vc.PresentedViewController;
                return vc;
            }
        }
    }
}