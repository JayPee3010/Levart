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


        public OverviewPage(Album a)  {
            InitializeComponent();
            album = a;
            Title = album.Name;
            DisplayAlert("images?", album.images.ToString(), "OK");
            if (album.images != null)
            {
                var count = 0;
                foreach (ImageSource image in album.images)
                {
                    photoGrid.Children.Add(new Image { Source = image }, count % 4, count % 4);
                    ++count;
                }
            }
        }


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

            album.images.Add(ImageSource.FromStream(() => file.GetStream()));
            fillPhotoGrid();
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
            
            album.images.Add(ImageSource.FromStream(() => file.GetStream()));
            fillPhotoGrid();
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

        public void fillPhotoGrid() {
            var count = 0;
            foreach (ImageSource image in album.images)
            {
                photoGrid.Children.Add(new Image { Source = image }, count%4, (int) count/4);
                ++count;
            }

        }

    }
}