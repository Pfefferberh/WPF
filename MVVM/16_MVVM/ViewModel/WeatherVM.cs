using _16_MVVM.Model;
using _16_MVVM.ViewModel.Commands;
using _16_MVVM.ViewModel.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace _16_MVVM.ViewModel
{
    public class WeatherVM : INotifyPropertyChanged
    {
        private string query;
        private CurrentConditions currentConditions;
        public ObservableCollection<City> Cities { get; set; } = new ObservableCollection<City>();
        private City selectedCity;
        public SearchCommand SearchCommand { get; set; }
        public Url url;
        public WeatherVM()
        {
            SearchCommand = new SearchCommand(this);
            Query = "";
        }
        public City SelectedCity
        {
            get { return selectedCity; }
            set
            {
                selectedCity = value;
                GetConditions();
                OnNotify();
            }
        }

        public CurrentConditions CurrentConditions
        {
            get => currentConditions;
            set
            {
                currentConditions = value;
                OnNotify();
            }
        }
        public string Query
        {
            get => query;
            set
            {
                query = value;
                OnNotify();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnNotify([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public async void MakeRequestCities()
        {
            List<City> temp = await AccuWeatherHelper.GetCities(Query);  
            Cities.Clear();
            foreach (var item in temp)
            {
                Cities.Add(item);
            }
        }

        private async void GetConditions()
        {
            if (SelectedCity != null)
            {
                CurrentConditions = await AccuWeatherHelper.GetCurrentConditions(SelectedCity.Key);
            }
            else
                CurrentConditions = new CurrentConditions();
        }
    }
}
