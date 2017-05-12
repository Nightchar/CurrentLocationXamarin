using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurrentLocationXamarin
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoDetailInputPage : ContentPage
    {
        public ToDoDetailInputPage()
        {
            InitializeComponent();
            BindingContext = new ToDoDetailInputPageViewModel(this);
        }

        private async void CurrentLocation_Clicked(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            ButtonCurrentLocation.IsEnabled = false;
            if (locator.IsGeolocationEnabled && locator.IsGeolocationAvailable)
            {
                var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);
                //await locator.StopListeningAsync();

                if (position == null)
                {
                    LabelGPS.Text = "null gps :(";
                    ButtonCurrentLocation.IsEnabled = true;
                    return;
                }
                ButtonCurrentLocation.IsVisible = false;
                LabelGPS.IsVisible = true;
                LabelGPS.Text = position.Latitude + "," + position.Longitude;
            }
            else
            {
                ButtonCurrentLocation.IsEnabled = true;
                LabelGPS.Text = "GPS is disabled!";
            }
        }
    }
}
