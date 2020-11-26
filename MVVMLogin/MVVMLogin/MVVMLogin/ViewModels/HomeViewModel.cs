using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MVVMLogin.Models;

namespace MVVMLogin.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public MenuOption Option { get; set; } = new MenuOption();

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }


        public HomeViewModel()
        {
            Name = Option.Name;
            LastName = Option.LastName;
            Initials = Option.Initials;
            Age = Option.Age;
            Nationality = Option.Nationality;
            Gender = Option.Gender;            
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
