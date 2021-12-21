using silka.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace silka.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountdownTimerPage : ContentPage
    {
        public CountdownTimerPage()
        {
            InitializeComponent();
            BindingContext = new CountdownTimerViewModel();
        }
    }
}