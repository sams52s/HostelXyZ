using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Threading.Tasks;
using HostelXyZ.LoginRegistration.Model;
using HostelXyZ.LoginRegistration.Service;

namespace HostelXyZ.LoginRegistration.ViewModel
{
    public class AllUserViewModel : BaseViewModel
    {
        public ObservableRangeCollection<UserModel> UserModel { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<UserModel> RemoveCommand { get; }

        public AllUserViewModel()
        {
            Title = "All User";

            UserModel = new ObservableRangeCollection<UserModel>();
           
            RefreshCommand = new AsyncCommand(Refresh);
            AddCommand = new AsyncCommand(Add);
            RemoveCommand = new AsyncCommand<UserModel>(Remove);
        }
        async Task Add()
        {
            var userName = await App.Current.MainPage.DisplayPromptAsync("UserName", "Name of user");
            var email = await App.Current.MainPage.DisplayPromptAsync("Email", "Email of uesr");
            var password = await App.Current.MainPage.DisplayPromptAsync("password", "password of uesr");
            await AuthService.AddUser(email, password);
            await Refresh();
        }
        async Task Remove(UserModel userModel)
        {
            await AuthService.RemoveUser(userModel.Id);
            await Refresh();
        }
        async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(2000);

            UserModel.Clear();

            var userModel = await AuthService.GetUser();

            UserModel.AddRange(userModel);

            IsBusy = false;
        }
    }
}
