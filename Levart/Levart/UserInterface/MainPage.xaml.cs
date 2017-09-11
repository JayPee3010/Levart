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
        public class Product {
            public int ID { get; set; }
            public string Name { get; set; }
            public decimal UnitCost { get; set; }
        }

        public static ObservableCollection<Product> ProductList = new ObservableCollection<Product> {
            new Product { ID=1, Name="Widget", UnitCost=19.99m},
            new Product { ID=2, Name="Whatzit", UnitCost=29.99m},
            new Product { ID=3, Name="Gadget", UnitCost=39.99m},
            new Product { ID=4, Name="Cog", UnitCost=49.99m},
            new Product { ID=5, Name="Sprocket", UnitCost=59.99m}
        };

        public static ObservableCollection<string> ObservableStringList = new ObservableCollection<string> {
            "One", "Two", "Three", "Four"
        };


        public MainPage() {
            InitializeComponent();

            albumListView.ItemsSource = ProductList;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e) {
            if(e.SelectedItem != null) {
                var selection = e.SelectedItem as Product;
                ((ListView)sender).SelectedItem = null;
                Navigation.PushAsync(new OverviewPage()); ;
            }
        }
	}
}
