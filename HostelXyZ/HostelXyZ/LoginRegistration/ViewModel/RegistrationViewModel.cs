﻿using HostelXyZ.LoginRegistration.View;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace HostelXyZ.LoginRegistration.ViewModel
{
    internal class RegistrationViewModel : INotifyPropertyChanged
    {
        public RegistrationViewModel(INavigation navigation)
        {
            Navigation = navigation;
            this.Loginbtn_Clicked = new Command(async () => await Navigation.PushAsync(new LoginView()));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation { get; set; }
        public ICommand Loginbtn_Clicked { get; }
    }
}