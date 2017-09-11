using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Levart.UserInterface;

namespace Levart
{
	public partial class MainPage : ContentPage
    {
        public class Album {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public static ObservableCollection<Album> ProductList = new ObservableCollection<Album> {
            new Album { ID=1, Name="Default"},
            new Album { ID=2, Name="  "},
            new Album { ID=3, Name="Gadget"},
            new Album { ID=4, Name="Cog"},
            new Album { ID=5, Name="Sprocket"}
        };

        public MainPage() {

            InitializeComponent();

            Title = "Albums";

            albumListView.ItemsSource = ProductList;
        }

        // Click on a list item
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e) {
            if(e.SelectedItem != null) {
                var selection = e.SelectedItem as Album;
                ((ListView)sender).SelectedItem = null; // reset the selected item
                Navigation.PushAsync(new OverviewPage()); ;
            }
        }
	}
}
