using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFImageLoadingTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ReactiveCommand<string> PageChangeButton { get; } = new ReactiveCommand<string>();
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            PageChangeButton.Subscribe(async x => await navigationService.NavigateAsync(x));
        }
    }
}
