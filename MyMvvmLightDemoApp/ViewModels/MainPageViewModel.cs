using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;


namespace MyMvvmLightDemoApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            //if (base.IsInDesignMode)
            //    Value = "Designtime value";
        }

        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            Value = parameter?.ToString();
            return Task.CompletedTask;
        }

        private string _Value;
        public string Value
        {
            get { return _Value; }
            set { Set(ref _Value, value); }
        }


        DelegateCommand _GotoDetailsCommand;
        public DelegateCommand GotoDetailsCommand
           => _GotoDetailsCommand ?? (_GotoDetailsCommand = new DelegateCommand(GotoDetailsCommandExecute, GotoDetailsCommandCanExecute));
        bool GotoDetailsCommandCanExecute() => true;
        void GotoDetailsCommandExecute()
        {
            NavigationService.Navigate(typeof(Views.DetailPage));
        }
    }
}
