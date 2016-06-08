using Template10.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Windows.UI.Xaml.Navigation;
using MyMvvmLightDemoApp.Mvvm;

namespace MyMvvmLightDemoApp.Mvvm
{
    
    public abstract class ViewModelBase :
         Template10.Services.NavigationService.INavigable
    {
        public virtual Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            return Task.CompletedTask;
        }

        public virtual Task OnNavigatedFromAsync(IDictionary<string, object> state, bool suspending)
        {
            return Task.CompletedTask;
        }

        public virtual Task OnNavigatingFromAsync(Template10.Services.NavigationService.NavigatingEventArgs args)
        {
            return Task.CompletedTask;
        }

        public bool IsInDesignMode()
        {
            return true;
        }

        [JsonIgnore]
        public Template10.Services.NavigationService.INavigationService NavigationService { get; set; }

        [JsonIgnore]
        public Template10.Common.IDispatcherWrapper Dispatcher { get; set; }

        [JsonIgnore]
        public Template10.Common.IStateItems SessionState { get; set; }
    }
}

