using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }
        
        void Button_Clicked(object sender, System.EventArgs e)
        { 

            if (txtEmail.Text == "admin" && txtPassword.Text == "123")
            {
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Oops", "Username or Password incorrect", "OK");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}