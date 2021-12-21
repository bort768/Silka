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
    public partial class Page_chest : ContentPage
    {
        public Page_chest()
        {
            InitializeComponent();
        }

        void EditorCompleted(object sender, EventArgs e)
        {
            var text = ((Editor)sender).Text; // sender is cast to an Editor to enable reading the `Text` property of the view.
        }
    }
}