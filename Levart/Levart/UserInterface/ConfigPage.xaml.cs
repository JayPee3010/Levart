using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Levart.UserInterface
{
    public partial class ConfigPage : ContentPage {

        public static ObservableCollection<Album> albumList;

        public ConfigPage(ObservableCollection<Album> list) {
            InitializeComponent();
            Title = "Config";
            albumList = list;
        }


        // Save new Album
        private void SaveButtonClicked(object sender, EventArgs e) {
            albumList.Add(new Album { Name = titleField.Text, images = new ObservableCollection<ImageSource> { } });
            Navigation.PushAsync(new MainPage(albumList));
        }
    }
}
