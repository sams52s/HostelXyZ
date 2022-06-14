using HostelXyZ.LoginRegistration.View;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace HostelXyZ.LoginRegistration.ViewModel
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public HomeViewModel(INavigation navigation)
        {
            Navigation = navigation;
            this.Loginbtn_Clicked = new Command(async () => await Navigation.PushAsync(new LoginView()));
        }

        public INavigation Navigation { get; set; }
        public ICommand Loginbtn_Clicked { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}