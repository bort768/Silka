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
    public partial class Main_Page_Gym : ContentPage
    {
        public Main_Page_Gym()
        {
            InitializeComponent();
            BindingContext = new ExerciseViewModel(Navigation);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_chest());
        }
    }
}