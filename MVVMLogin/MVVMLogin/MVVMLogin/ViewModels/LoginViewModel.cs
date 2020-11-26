using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMLogin.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public string Email {get; set;}
        public string Password {get; set;}

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand LoginCommand => new Command(async () =>
        {
            if (String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(Password))
            {
               await  App.Current.MainPage.DisplayAlert("Error", "There is an empty field. Please complete it and try again", "OK");
            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new MVVMLogin.Views.HomePage());
            }
        });

        public ICommand RegisterCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new MVVMLogin.Views.RegisterPage());
        });
    }
}
