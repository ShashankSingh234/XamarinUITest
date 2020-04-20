using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UITestDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(EmailEntry.Text == "email@email.com" && PasswordEntry.Text == "password")
            {
                await Navigation.PushAsync(new Page1());
                //ResultLabel.Text = "LoggedIn successfully.";
            }
            else
            {
                //await Navigation.PushAsync(new Page2());
                ResultLabel.Text = "Invalid email or password.";
            }
        }
    }
}
