using HostelXyZ.LoginRegistration.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HostelXyZ.LoginRegistration.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);

        }
    }
}