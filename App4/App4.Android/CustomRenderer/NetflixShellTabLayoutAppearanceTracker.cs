using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace App4.Droid.CustomRenderer
{
    public class NetflixShellTabLayoutAppearanceTracker : IShellTabLayoutAppearanceTracker
    {

        public NetflixShellTabLayoutAppearanceTracker(IShellContext context)
        {

        }

        public void Dispose()
        {
            
        }

        public void ResetAppearance(TabLayout tabLayout)
        {
            throw new NotImplementedException();
        }

        public void SetAppearance(TabLayout tabLayout, ShellAppearance appearance)
        {
            tabLayout.TextAlignment = Android.Views.TextAlignment.TextStart;
            tabLayout.TabMode = TabLayout.GravityFill;
            tabLayout.TabGravity = TabLayout.GravityFill;
            tabLayout.SetBackgroundColor(Android.Graphics.Color.Fuchsia);
        }
    }
}