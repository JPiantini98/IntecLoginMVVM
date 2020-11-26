using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVVMLogin.Models
{
    public class MenuOption : INotifyPropertyChanged
    {
        public string Name = "Jorge";
        public string LastName = "Piantini";
        public string Initials = "JP";
        public int Age = 22;
        public string Nationality = "flag.jpg";
        public string Gender = "male.png";

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
