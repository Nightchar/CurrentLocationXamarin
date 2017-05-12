using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CurrentLocationXamarin
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CurrentLocationXamarin.ToDoDetailInputPage();
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
