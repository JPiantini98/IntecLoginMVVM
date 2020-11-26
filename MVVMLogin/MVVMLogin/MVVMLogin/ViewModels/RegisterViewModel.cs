using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMLogin.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordVerify { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand RegisterCommand => new Command(async () =>
        {
            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(Password) || String.IsNullOrEmpty(PasswordVerify))
            {
                await App.Current.MainPage.DisplayAlert("Error", "There is an empty field. Please complete it and try again", "OK");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Welcome " + Name, "Your registrations has beeing succesfull", "OK");
                await App.Current.MainPage.Navigation.PopAsync();
            }
        });
    }
}
