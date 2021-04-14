using Xamarin.Forms;
using Roster.Client.ViewModels;

namespace Roster.Client.Views
{
    [System.ComponentModel.DesignTimeVisible(false)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            this.BindingContext = new HomeViewModel();
        }
    }
}