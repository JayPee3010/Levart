using System;

using Xamarin.Forms;

namespace Levart.UserInterface
{
    public class ConfigPage : ContentPage
    {
        public ConfigPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

