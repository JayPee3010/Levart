﻿using System;
using System.IO;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace Levart.UserInterface
{
    public partial class DetailPage : ContentPage
    {

            //void OnImagePickerFinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs args)
            //{
            //    UIImage image = args.EditedImage ?? args.OriginalImage;

            //    if (image != null)
            //    {
            //        // Convert UIImage to .NET Stream object
            //        NSData data = image.AsJPEG(1);
            //        Stream stream = data.AsStream();

            //        // Set the Stream as the completion of the Task
            //        taskCompletionSource.SetResult(stream);
            //    }
            //    else
            //    {
            //        taskCompletionSource.SetResult(null);
            //    }
            //    imagePicker.DismissModalViewController(true);
            //}

            //void OnImagePickerCancelled(object sender, EventArgs args)
            //{
            //    taskCompletionSource.SetResult(null);
            //    imagePicker.DismissModalViewController(true);
            //}

            //public Task<Stream> GetImageStreamAsync()
            //{
            //    throw new NotImplementedException();
            //}

            ////protected internal DetailPage()
            ////{

            ////}
        }
}