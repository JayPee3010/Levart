using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace Levart.UserInterface
{
    public partial class OverviewPage : ContentPage
    {
        public class Image
        {
            public string Location { get; set; }
            public string Name { get; set; }
        }

        public static ObservableCollection<Image> AlbumList = new ObservableCollection<Image> {
            new Image { Location="", Name="Default"},
            new Image { Location="", Name="  "},
            new Image { Location="", Name="Gadget"},
            new Image { Location="", Name="Cog"},
            new Image { Location="", Name="Sprocket"}
        };


        public OverviewPage(string selectedItem)
        {
            InitializeComponent();

            Title = selectedItem;
        }

       
    }
}