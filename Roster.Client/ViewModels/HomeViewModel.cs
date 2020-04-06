using System.ComponentModel;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public partial class HomeViewModel : INotifyPropertyChanged
    {
        private string _title = "Roster App";

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        public Command UpdateApplicationCommand { get; }

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(UpdateApplicationExecute);
        }

        private void UpdateApplicationExecute()
        {
            Title = "Roster App (v2.0)";
        }
    }
}