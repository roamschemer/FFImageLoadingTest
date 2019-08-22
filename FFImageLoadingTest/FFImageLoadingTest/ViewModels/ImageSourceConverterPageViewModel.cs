using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFImageLoadingTest.ViewModels
{
    public class ImageSourceConverterPageViewModel : ViewModelBase
    {
        public class MenuItem
        {
            public string Image { get; set; }
        }
        public ReactiveProperty<String> Image1 { get; set; } = new ReactiveProperty<string>("FFImageLoadingTest.Image.anime.gif");
        public ReactiveProperty<String> Image2 { get; set; } = new ReactiveProperty<string>("FFImageLoadingTest.Image.noanime.png");
        public ReactiveProperty<String> Image3 { get; set; } = new ReactiveProperty<string>("FFImageLoadingTest.Image.noanime.gif");
        public ReactiveProperty<String> Image4 { get; set; } = new ReactiveProperty<string>("FFImageLoadingTest.Image.noanime.png");
        public ReactiveCollection<MenuItem> ListView { get; set; } = new ReactiveCollection<MenuItem>();

        public ImageSourceConverterPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            ListView = new ReactiveCollection<MenuItem>();
            foreach (var i in Enumerable.Range(1, 50))
            {
                ListView.Add(new MenuItem { Image = "FFImageLoadingTest.Image.noanime.jpg" });
                ListView.Add(new MenuItem { Image = "FFImageLoadingTest.Image.noanime.png" });
            }
        }
    }
}
