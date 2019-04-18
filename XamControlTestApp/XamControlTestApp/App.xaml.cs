using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamControlTestApp.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamControlTestApp
{
    public partial class App : Application
    {
        private static App thisApp;
        public static bool IsUserLoggedIn { get; set; }
        public App()
        {
            thisApp = this;
            IsUserLoggedIn = false;
            InitializeComponent();           
            SwitchMainPage();
        }


        public static App CurrentApp
        {
            get
            {
                return thisApp;
            }
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
        public void SwitchMainPage()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (!IsUserLoggedIn)
                {
                    //Show Login PAge
                    MainPage = new LoginPage();
                }
                else
                {
                    MainPage = new MainPage();
                }
            });
        }

    }
}
