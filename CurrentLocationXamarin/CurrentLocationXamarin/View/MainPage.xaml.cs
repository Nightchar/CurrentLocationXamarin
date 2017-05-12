using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Geolocator;

namespace CurrentLocationXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CurrentLocation_Button_Clicked(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;
            labelGPS.Text = "Getting gps";

            ButtonGPS.IsEnabled = false;
            if (locator.IsGeolocationEnabled && locator.IsGeolocationAvailable)
            {
                var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);
                //await locator.StopListeningAsync();

                if (position == null)
                {
                    labelGPS.Text = "null gps :(";
                    ButtonGPS.IsEnabled = true;
                    return;
                }
                ButtonGPS.IsVisible = false;
                labelGPS.Text = string.Format("Time: {0} \nLat: {1} \nLong: {2} \n Altitude: {3} \nAltitude Accuracy: {4} \nAccuracy: {5} \n Heading: {6} \n Speed: {7}",
            position.Timestamp, position.Latitude, position.Longitude,
            position.Altitude, position.AltitudeAccuracy, position.Accuracy, position.Heading, position.Speed);
            }
            else
            {
                ButtonGPS.IsEnabled = true;
                labelGPS.Text = "GPS is disabled!";
            }
        }
    }
}

