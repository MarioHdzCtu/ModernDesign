using ModernDesign.Core;
using System;

namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }   
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand ConfigurationViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        public ConfigurationViewModel ConfigurationVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set {
                _currentView = value;
                OnPropertyChanged();
            }
        }



        public MainViewModel() {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            ConfigurationVM = new ConfigurationViewModel();
            CurrentView = HomeVM;
            HomeViewCommand = new RelayCommand(o => {
                CurrentView = HomeVM;
            });
            DiscoveryViewCommand = new RelayCommand(o => {
                CurrentView = DiscoveryVM;
            });
            ConfigurationViewCommand = new RelayCommand(o => {
                CurrentView = ConfigurationVM;
            });


        }
    }
}
