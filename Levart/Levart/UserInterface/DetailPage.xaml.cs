using System;
using System.IO;
using System.Collections.Generic;
using UIKit;
using Xamarin.Forms;
using System.Threading.Tasks;
using UIKit;
using Foundation;

namespace Levart.UserInterface
{
    public partial class DetailPage : ContentPage
    {
<<<<<<< HEAD
        public class PicturePickerImplementation : IPicturePicker
        {
            TaskCompletionSource<Stream> taskCompletionSource;
            UIImagePickerController imagePicker;

            void OnImagePickerFinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs args)
            {
                UIImage image = args.EditedImage ?? args.OriginalImage;

                if (image != null)
                {
                    // Convert UIImage to .NET Stream object
                    NSData data = image.AsJPEG(1);
                    Stream stream = data.AsStream();

                    // Set the Stream as the completion of the Task
                    taskCompletionSource.SetResult(stream);
                }
                else
                {
                    taskCompletionSource.SetResult(null);
                }
                imagePicker.DismissModalViewController(true);
            }

            void OnImagePickerCancelled(object sender, EventArgs args)
            {
                taskCompletionSource.SetResult(null);
                imagePicker.DismissModalViewController(true);
            }

            public Task<Stream> GetImageStreamAsync()
            {
                throw new NotImplementedException();
            }
=======
        protected internal DetailPage()
        {
            //imagePicker = new UIImagePickerController();
            //imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
            //imagePicker.MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary);

            //imagePicker.FinishedPickingMedia += Handle_FinishedPickingMedia;
            //imagePicker.Canceled += Handle_Canceled;

            //NavigationController.PresentModalViewController(imagePicker, true);

            //void Handle_FinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
            //{
                // determine what was selected, video or image
                //bool isImage = false;
                //switch (e.Info[UIImagePickerController.MediaType].ToString())
                //{
                //    case "public.image":
                //        Console.WriteLine("Image selected");
                //        isImage = true;
                //        break;
                //    case "public.video":
                //        Console.WriteLine("Video selected");
                //        break;
                //}

                // get common info (shared between images and video)
                //NSUrl referenceURL = e.Info[new NSString("UIImagePickerControllerReferenceUrl")] as NSUrl;
                //if (referenceURL != null)
                    //Console.WriteLine("Url:" + referenceURL.ToString());

                // if it was an image, get the other image info
                //if (isImage)
                //{
                    // get the original image
                    //UIImage originalImage = e.Info[UIImagePickerController.OriginalImage] as UIImage;
                    //if (originalImage != null)
                    //{
                        //// do something with the image
                        //Console.WriteLine("got the original image");
                //        //imageView.Image = originalImage; // display
                //    }
                //}
                //else
                //{ // if it's a video
                  // get video url
                    //NSUrl mediaURL = e.Info[UIImagePickerController.MediaURL] as NSUrl;
                    //if (mediaURL != null)
                    //{
                        //Console.WriteLine(mediaURL.ToString());
                    //}
                //}
                // dismiss the picker
                //imagePicker.DismissModalViewControllerAnimated(true);
           // }
            //void Handle_Canceled(object sender, EventArgs e)
            //{
                //imagePicker.DismissModalViewControllerAnimated(true);
            //}


>>>>>>> 95a520edb897908d27633a3c320159025250060a
        }
    }
}