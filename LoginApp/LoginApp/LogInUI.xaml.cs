using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInUI : ContentPage
    {
        public ICommand TapCommand => new Command<string>(OpenBrowser);

        public LogInUI()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_ClickedLogIn(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                Navigation.PushAsync(new HomeFlyout());
            }
            else
            {
                DisplayAlert("Ops..","Username or Password is incorrect!","Ok");
            }
        }

        private void TapGestureRecognizer_TappedRegister(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        void OpenBrowser(string url)
        {
            Launcher.OpenAsync(url);
        }
    }
}