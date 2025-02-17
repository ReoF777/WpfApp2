using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace WpfApp2.ViewModels
{
    public partial class Page1ViewModel : ObservableObject
    {
        private readonly MainViewModel _mainViewModel;

        public Page1ViewModel (MainViewModel mainViewModel) {
            _mainViewModel = mainViewModel;
            _mainViewModel.PropertyChanged += (_, e) =>
            {
                if(e.PropertyName == nameof(MainViewModel.Counter))
                {
                    OnPropertyChanged(nameof(Counter));
                }
            };
        }

        public int Counter => _mainViewModel.Counter;

        [RelayCommand]
        private void IncrementCounter () => _mainViewModel.IncrementCounter();
    }
}
