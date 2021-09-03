using ListSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListSample.ViewModels
{
    public class PlacesViewModel : INotifyPropertyChanged
    {
        private Place _selectedPlace;

        public event PropertyChangedEventHandler PropertyChanged;

        public Place SelectedPlace {
            get
            {
                return _selectedPlace;
            }
            set
            {
                _selectedPlace = value;
                if(_selectedPlace != null)
                {
                    SelectedPlaceCommand.Execute(_selectedPlace);
                }
            }
        }

        private ICommand SelectedPlaceCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand ShowCommand { get; }
        public ObservableCollection<Place> Places { get; set; } = new ObservableCollection<Place>()
        {
            new Place("Mirador Norte", "Parque"),
            new Place("Mirador Sur", "Parque"),
            new Place("Helados Bon", "Heladeria"),
            new Place("INTEC", "Universidad"),
            new Place("BRAVO", "Supermercado")
        };
        public ObservableCollection<PlaceGroup> GroupedPlaces { get; set; } = new ObservableCollection<PlaceGroup>()
        {
            new PlaceGroup("Parque"),
            new PlaceGroup("Recinto")
        };

        public PlacesViewModel()
        {
            SelectedPlaceCommand = new Command<Place>(OnPlaceSelected);
            AddCommand = new Command(AddPlace);
            DeleteCommand = new Command<Place>(DeletePlace); ;
            ShowCommand = new Command(ShowPlace); ;

            GroupedPlaces[0].Add(new Place("Mirador Norte", "Parque"));
            GroupedPlaces[0].Add(new Place("Mirador Sur", "Parque"));

            GroupedPlaces[1].Add(new Place("INTEC", "Recinto"));
            GroupedPlaces[1].Add(new Place("UNIBE", "Recinto"));
        }

        private void ShowPlace()
        {
            throw new NotImplementedException();
        }

        private void DeletePlace(Place place)
        {
            Places.Remove(place);
        }

        private async void AddPlace(object addPlace)
        {
            var name = await App.Current.MainPage.DisplayPromptAsync("Especifique", "Nombre de lugar");
            var category = await App.Current.MainPage.DisplayPromptAsync("Especifique", "Categoria");
            //Places.Add(new Place(name, category));

            Places = new ObservableCollection<Place>()
            {
                new Place("Mirador Norte", "Parque"),
                new Place("Mirador Sur", "Parque"),
                new Place("Helados Bon", "Heladeria"),
                new Place("INTEC", "Universidad"),
                new Place("BRAVO", "Supermercado"),
                new Place(name, category)
            };
        }

        private async void OnPlaceSelected(Place place)
        {
            await App.Current.MainPage.DisplayAlert(place.Name, place.Category, "OK");
        }
    }
}
