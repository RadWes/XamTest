using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamControlTestApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        private string password = "password";
        private string user = "user@me.com";
		public LoginPage ()
		{
			InitializeComponent ();
            slResetPW.IsVisible = false;

            eEmail.Text = user;
            ePassword.Text = password;

            btnLogin.Clicked            += BtnLogin_Clicked;
            btnForgotPassword.Clicked   += BtnForgotPassword_Clicked;
            btnResetSave.Clicked        += BtnResetSave_Clicked;
            btnResetCancel.Clicked      += BtnResetCancel_Clicked;
		}

        private void BtnResetCancel_Clicked(object sender, EventArgs e)
        {
            slLogin.IsVisible = true;
            slResetPW.IsVisible = false;
        }

        private void BtnResetSave_Clicked(object sender, EventArgs e)
        {
            password = eNewPassword.Text;
        }

        private void BtnForgotPassword_Clicked(object sender, EventArgs e)
        {
            slLogin.IsVisible = false;
            slResetPW.IsVisible = true;
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            if (eEmail.Text == user && ePassword.Text == password)
            {
                App.IsUserLoggedIn = true;
                App.CurrentApp.SwitchMainPage();
            }
        }

        private void ENewPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            eNewPasswordConfirm.Text = eNewPassword.Text;
        }
    }
}