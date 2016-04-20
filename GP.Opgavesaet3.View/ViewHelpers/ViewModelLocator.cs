using System;
using GP.Opgavesaet3.ViewModel;

namespace GP.Opgavesaet3.View.ViewHelpers
{
    public class ViewModelLocator
    {
        private readonly Lazy<MainWindowViewModel> _mainWindowViewModel = new Lazy<MainWindowViewModel>();
        public MainWindowViewModel MainWindowViewModel => _mainWindowViewModel.Value;
    }
}
