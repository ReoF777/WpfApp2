using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace WpfApp2.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _counter = 0;

        [ObservableProperty]
        private object _currentView;

        private readonly Page1ViewModel _page1ViewModel;
        private readonly Page2ViewModel _page2ViewModel;

        public MainViewModel () {
            _page1ViewModel = new Page1ViewModel(this);
            _page2ViewModel = new Page2ViewModel(this);

            CurrentView = _page1ViewModel;
        }

        [RelayCommand]
        private void ShowPage1 () => CurrentView = _page1ViewModel;

        [RelayCommand]
        private void ShowPage2 () => CurrentView = _page2ViewModel;

        [RelayCommand]
        public void IncrementCounter () => Counter++;
    }
}