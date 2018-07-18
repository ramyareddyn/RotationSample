using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RotationSample
{
    public partial class SamplePage : ContentPage
    {
        public SamplePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<ISettingsService>().ChangeOrientation("Landscape");
        }
    }
}
