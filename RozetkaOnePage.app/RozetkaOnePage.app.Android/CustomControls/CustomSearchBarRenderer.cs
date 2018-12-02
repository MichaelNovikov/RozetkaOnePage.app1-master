using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RozetkaOnePage.app.CustomControls;
using RozetkaOnePage.app.Droid.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchBarRenderer))]
namespace RozetkaOnePage.app.Droid.CustomControls
{
    class CustomSearchBarRenderer : SearchBarRenderer
    {
        public CustomSearchBarRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Xamarin.Forms.Color.Transparent.ToAndroid());
                Control.SetPadding(0, 0, 0, 0);
                Element.VerticalOptions = LayoutOptions.Center;
                Element.HorizontalOptions = LayoutOptions.FillAndExpand;
            }
        }
    }
}