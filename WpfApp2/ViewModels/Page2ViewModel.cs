using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace WpfApp2.ViewModels
{
    public partial class Page2ViewModel : ObservableObject
    {
        private readonly MainViewModel _mainViewModel;

        public int Counter => _mainViewModel.Counter;

        public Page2ViewModel (MainViewModel mainViewModel) {
            _mainViewModel = mainViewModel;
            _mainViewModel.PropertyChanged += (_, e) =>
            {
                if (e.PropertyName == nameof(MainViewModel.Counter))
                {
                    OnPropertyChanged(nameof(Counter));
                }
            };
        }

        [RelayCommand]
        private void IncrementCounter () => _mainViewModel.IncrementCounter();
    }
}
