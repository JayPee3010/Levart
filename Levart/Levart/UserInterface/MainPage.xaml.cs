using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Levart.UserInterface;
using Plugin.Media;
using System.IO;
using Plugin.Media.Abstractions;

namespace Levart
{
    public partial class MainPage : ContentPage {
    
        public static ObservableCollection<Album> albumList = new ObservableCollection<Album> {
            new Album { Name="Default" }
        };

        public MainPage() {
            InitializeComponent();
            Title = "Albums";
            albumListView.ItemsSource = albumList;
        }
        public MainPage(ObservableCollection<Album> al) {
            InitializeComponent();
            Title = "Albums";
            albumListView.ItemsSource = al;
        }

        // Create new Album
        private void MenuItem_OnClicked(object sender, EventArgs e) {
            Navigation.PushAsync(new ConfigPage(albumList));
        }


        // Click on a list item (Album)
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e) {
            if(e.SelectedItem != null) {
                var listIndex = (albumListView.ItemsSource as ObservableCollection<Album>).IndexOf(e.SelectedItem as Album);
                var selection = e.SelectedItem as Album;
                ((ListView)sender).SelectedItem = null; // reset the selected item
                Navigation.PushAsync(new OverviewPage(albumList[listIndex]));
            }
        }
	}
}
