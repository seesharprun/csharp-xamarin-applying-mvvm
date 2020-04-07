using Roster.Client.Models;
using System.Collections.ObjectModel;
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

        public ObservableCollection<Person> People { get; }

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(UpdateApplicationExecute);
            People = new ObservableCollection<Person>();
            People.Add(new Person { Name = "Delores Feil", Company = "Legros Group" });
            People.Add(new Person { Name = "Ann Zboncak", Company = "Ledner - Ferry" });
            People.Add(new Person { Name = "Jaime Lesch", Company = "Herzog and Sons" });
        }

        private void UpdateApplicationExecute()
        {
            Title = "Roster App (v2.0)";
        }
    }
}