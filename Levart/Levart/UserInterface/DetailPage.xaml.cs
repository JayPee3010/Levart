using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Levart.UserInterface
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            imagePicker = new UIImagePickerController();
            imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
            imagePicker.MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary);

            imagePicker.FinishedPickingMedia += Handle_FinishedPickingMedia;
            imagePicker.Canceled += Handle_Canceled;

            NavigationController.PresentModalViewController(imagePicker, true);

            protected void Handle_FinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
            {
                // determine what was selected, video or image
                bool isImage = false;
                switch (e.Info[UIImagePickerController.MediaType].ToString())
                {
                    case "public.image":
                        Console.WriteLine("Image selected");
                        isImage = true;
                        break;
                    case "public.video":
                        Console.WriteLine("Video selected");
                        break;
                }

                // get common info (shared between images and video)
                NSUrl referenceURL = e.Info[new NSString("UIImagePickerControllerReferenceUrl")] as NSUrl;
                if (referenceURL != null)
                    Console.WriteLine("Url:" + referenceURL.ToString());

                // if it was an image, get the other image info
                if (isImage)
                {
                    // get the original image
                    UIImage originalImage = e.Info[UIImagePickerController.OriginalImage] as UIImage;
                    if (originalImage != null)
                    {
                        // do something with the image
                        Console.WriteLine("got the original image");
                        imageView.Image = originalImage; // display
                    }
                }
                else
                { // if it's a video
                  // get video url
                    NSUrl mediaURL = e.Info[UIImagePickerController.MediaURL] as NSUrl;
                    if (mediaURL != null)
                    {
                        Console.WriteLine(mediaURL.ToString());
                    }
                }
                // dismiss the picker
                imagePicker.DismissModalViewControllerAnimated(true);
            }
            void Handle_Canceled(object sender, EventArgs e)
            {
                imagePicker.DismissModalViewControllerAnimated(true);
            }


        }
    }
}