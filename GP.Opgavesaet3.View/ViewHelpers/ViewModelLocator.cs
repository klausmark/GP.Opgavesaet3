using System;
using GP.Opgavesaet3.ViewModel;

namespace GP.Opgavesaet3.View.ViewHelpers
{
    public class ViewModelLocator
    {
        private readonly Lazy<MainWindowViewModel> _mainWindowViewModel = new Lazy<MainWindowViewModel>();
        public MainWindowViewModel MainWindowViewModel => _mainWindowViewModel.Value;

        private readonly Lazy<Opgave21UserControlViewModel> _opgave21UserControlViewModel = new Lazy<Opgave21UserControlViewModel>();
        public Opgave21UserControlViewModel Opgave21UserControlViewModel => _opgave21UserControlViewModel.Value;

        private readonly Lazy<Opgave31UserControlViewModel> _opgave31UserControlViewModel = new Lazy<Opgave31UserControlViewModel>();
        public Opgave31UserControlViewModel Opgave31UserControlViewModel => _opgave31UserControlViewModel.Value;
    }
}
