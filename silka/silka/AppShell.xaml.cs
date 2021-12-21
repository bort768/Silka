using silka.Views;
using Xamarin.Forms;

namespace silka
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CountdownTimerPage), typeof(CountdownTimerPage));
        }


    }
}
