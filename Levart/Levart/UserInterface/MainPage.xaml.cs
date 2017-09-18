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
    public partial class MainPage : ContentPage
    {
        private async void TakePictureButton_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if(!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", "No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                Directory = "TestAlbum",
                SaveToAlbum = true,
                Name = "test.jpg"
            });

            if (file == null)
                return;

            Image1.Source = ImageSource.FromStream(() => file.GetStream());
        }

        private async void UploadPictureButton_Clicked(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("No Upload", "Picking a photo is not supported.", "OK");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();
            if(file == null)
            {
                return;
            }

            Image1.Source = ImageSource.FromStream(() => file.GetStream());
        }
        
        public static ObservableCollection<Album> albumList = new ObservableCollection<Album> {
            new Album { ID=1, Name="Default"},
            new Album { ID=2, Name="  "},
            new Album { ID=3, Name="Gadget"},
            new Album { ID=4, Name="Cog"},
            new Album { ID=5, Name="Sprocket"}
        };

        public MainPage() {

            InitializeComponent();

            Title = "Albums";

            albumListView.ItemsSource =albumList;

        }

        private void MenuItem_OnClicked(object sender, EventArgs e) {
            albumList.Add(new Album { ID = 6, Name = "Test" });
        }


        // Click on a list item
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e) {
            if(e.SelectedItem != null) {
                var selection = e.SelectedItem as Album;
                ((ListView)sender).SelectedItem = null; // reset the selected item
                Navigation.PushAsync(new OverviewPage(selection.Name));
            }
        }
	}
}
