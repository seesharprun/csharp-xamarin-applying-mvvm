using Roster.Client.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public partial class HomeViewModel : INotifyPropertyChanged
    {
        private string _title = "Roster";

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

        public Command UpdateApplicationCommand;

        public ObservableCollection<Person> People { get; }

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(UpdateApplicationExecute);
        }

        private void UpdateApplicationExecute()
        {
            Title = "Roster v2";
        }
    }
}