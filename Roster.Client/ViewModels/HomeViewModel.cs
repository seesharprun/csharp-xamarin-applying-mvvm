using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Roster.Client.Models;
using System.Collections.Generic;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private string _title = "Roster App";
        public event PropertyChangedEventHandler PropertyChanged;

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(ExecuteUpdateApplication);
            People = new ObservableCollection<Person>(
                new List<Person> {
                    new Person { Name = "Delores Feil", Company = "Legros Group" },
                    new Person { Name = "Ann Zboncak", Company = "Ledner - Ferry" },
                    new Person { Name = "Jaime Lesch", Company = "Herzog and Sons" }
                }
            );
        }

        public string Title
        {
            get => _title;
            set {
                _title = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        public ObservableCollection<Person> People { get; }

        public Command UpdateApplicationCommand { get; }

        private void ExecuteUpdateApplication()
        {
            Title = "Roster App (v2.0)";
        }
    }
}