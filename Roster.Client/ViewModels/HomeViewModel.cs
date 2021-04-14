using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private string _title = "Roster App";
        public event PropertyChangedEventHandler PropertyChanged;

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(ExecuteUpdateApplication);
        }

        public string Title
        {
            get => _title;
            set {
                _title = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        public Command UpdateApplicationCommand { get; }

        private void ExecuteUpdateApplication()
        {
            Title = "Roster App (v2.0)";
        }
    }
}