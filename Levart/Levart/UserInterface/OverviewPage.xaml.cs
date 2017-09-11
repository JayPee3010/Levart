using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Levart.UserInterface
{
    public partial class OverviewPage : ContentPage
    {
        public OverviewPage(string selectedItem)
        {
            InitializeComponent();

            Title = selectedItem;
        }
    }
}
