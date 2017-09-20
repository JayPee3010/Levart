using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Plugin.Media;
using Plugin.Media.Abstractions;

using Xamarin.Forms;

namespace Levart.UserInterface
{
    public partial class OverviewPage : ContentPage
    {

        private Album album;

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


		private async void TakePictureButton_Clicked(object sender, EventArgs e)
		{
			await CrossMedia.Current.Initialize();

			if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
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
			if (file == null)
			{
				return;
			}

			Image1.Source = ImageSource.FromStream(() => file.GetStream());
		}

        public OverviewPage(Album a)
        {
            InitializeComponent();
            album = a;
            Title = album.Name;
        }

		async void OnNewPhotoClicked(object sender, EventArgs e)
		{
			var action = await DisplayActionSheet("Do you wanna add a new photo?", "Cancel", null, "Camera", "Photo Libary");
			Debug.WriteLine("Action: " + action);
            switch (action) {
                case "Camera":
                    TakePictureButton_Clicked(sender, e);
                    break;
                case "Photo Libary":
                    UploadPictureButton_Clicked(sender, e);
                    break;
            }
		}


    }
}