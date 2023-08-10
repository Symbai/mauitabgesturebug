using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Page1");
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.DisplayAlert("", "Hello World", "Ok");
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {

        }
    }

    public class Blabla : INotifyPropertyChanged
    {
        static Blabla _Instance;
        public static Blabla Instance => _Instance ?? new();
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<string> Items { get; set; } = new() { "Label 1", "Label 2", "Label 3", "Label 4" };


        bool _IsRefreshing;
        public bool IsRefreshing
        {
            get => _IsRefreshing;
            set
            {
                if (value == _IsRefreshing) return;
                _IsRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

    }
}