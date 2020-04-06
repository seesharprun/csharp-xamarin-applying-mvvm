using System.ComponentModel;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public partial class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        public Command UpdateApplicationCommand;
    }
} 