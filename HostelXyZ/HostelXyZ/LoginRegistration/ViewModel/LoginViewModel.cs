using HostelXyZ.LoginRegistration.Request;
using HostelXyZ.LoginRegistration.View;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HostelXyZ.LoginRegistration.ViewModel
{
    internal class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _email, _password;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public INavigation Navigation { get; set; }
        public ICommand Loginbtn_Clicked { get; private set; }
        public ICommand Registrationbtn_Clicked { get; private set; }

        public LoginViewModel(INavigation navigation)
        {
            Navigation = navigation;
            this.Loginbtn_Clicked = new Command(async () => await Login());
            this.Registrationbtn_Clicked = new Command(async () => await Navigation.PushAsync(new RegistrationView()));
        }
        public async Task Login()
        {
            LoginRequest loginRequest = new LoginRequest();
            bool loginValidation = loginRequest.Login(_email,_password);
            if(loginValidation)
                await Navigation.PushAsync(new HomePage());
            else
                await Navigation.PushAsync(new LoginView());
        }
    }
}
