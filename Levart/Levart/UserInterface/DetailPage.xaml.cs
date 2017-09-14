using System;
using System.IO;
using System.Collections.Generic;
using UIKit;
using Xamarin.Forms;
using System.Threading.Tasks;
using Foundation;

namespace Levart.UserInterface
{
    public partial class DetailPage : ContentPage
    {
        image.Source = Device.OnPlatform(
                    iOS: ImageSource.FromFile("Images/corgi.png"),
            Android:  ImageSource.FromFile("corgi.png"),
            WinPhone: ImageSource.FromFile("Images/corgi.png"));    }
}