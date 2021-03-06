using HostelXyZ.LoginRegistration.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HostelXyZ.LoginRegistration.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationView : ContentPage
    {
        public RegistrationView()
        {
            InitializeComponent();
            BindingContext = new RegistrationViewModel(Navigation);
        }
    }
}