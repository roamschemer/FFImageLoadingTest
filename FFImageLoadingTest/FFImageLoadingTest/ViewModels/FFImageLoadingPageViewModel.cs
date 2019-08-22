using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFImageLoadingTest.ViewModels
{
    public class FFImageLoadingPageViewModel : ViewModelBase
    {

        public ReactiveCollection<string> ListView { get; set; } = new ReactiveCollection<string>();
        public FFImageLoadingPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            ListView = new ReactiveCollection<string>();
            foreach (var i in Enumerable.Range(1, 50))
            {
                ListView.Add("resource://FFImageLoadingTest.Image.noanime.jpg");
                ListView.Add("resource://FFImageLoadingTest.Image.noanime.png");
            }
        }
    }
}
