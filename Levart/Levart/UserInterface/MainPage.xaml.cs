using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Levart
{
	public partial class MainPage : ContentPage
	{


        public static ObservableCollection<string> ObservableStringList = new ObservableCollection<string>
        {
            "One", "Two", "Three", "Four"
        };

        public MainPage()
        {
            InitializeComponent();

            
            listView.ItemsSource = ObservableStringList;
        }
	}
}
