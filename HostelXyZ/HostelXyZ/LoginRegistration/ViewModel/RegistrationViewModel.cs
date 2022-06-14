using HostelXyZ.LoginRegistration.View;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HostelXyZ.LoginRegistration.ViewModel
{
    internal class RegistrationViewModel : INotifyPropertyChanged
    {
        private string _email, _password, _confiremPassword;
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
        public string ConfiremPassword
        {
            get { return _confiremPassword; }
            set
            {
                _confiremPassword = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ConfiremPassword"));
                


            }
        }
        public RegistrationViewModel(INavigation navigation)
        {
            Navigation = navigation;
            this.Loginbtn_Clicked = new Command(async () => await Navigation.PushAsync(new LoginView()));
            this.RegistrationBtn_Clicked = new Command(async () => await Registration());
        }
        public async Task Registration()
        {
            if(string.IsNullOrEmpty(Email)||string.IsNullOrEmpty(Password)||string.IsNullOrEmpty(ConfiremPassword))
                await Navigation.PushAsync(new LoginView());
            else
                await Navigation.PushAsync(new RegistrationView());
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation { get; set; }
        public ICommand Loginbtn_Clicked { get; }
        public ICommand RegistrationBtn_Clicked { get; private set; }
    }
}