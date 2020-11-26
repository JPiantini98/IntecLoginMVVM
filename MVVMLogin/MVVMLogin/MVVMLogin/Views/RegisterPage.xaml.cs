using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : MasterDetailPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new MVVMLogin.ViewModels.RegisterViewModel();
        }
    }
}