using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWAFlipView
{

    public class MyItem
    {
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
    }



    public sealed partial class MainPage : Page
    {
        List<MyItem> listImage = new List<MyItem>();


        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            InitImage();
            flipView.ItemsSource = listImage;

        }

        private void InitImage()
        {
            listImage.Add(new MyItem() { ImageName = "Iron men", ImagePath = "ms-appx:///Assets/1.jpg" });
            listImage.Add(new MyItem() { ImageName = "Spidermen", ImagePath = "ms-appx:///Assets/2.jpg" });
            listImage.Add(new MyItem() { ImageName = "Captan", ImagePath = "ms-appx:///Assets/3.jpg" });

        }
    }
}
