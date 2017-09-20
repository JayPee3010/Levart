using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Levart
{
    public class Album
    {
        public string Name { get; set; }
        //public static ObservableCollection<Entry> entryList { get; set; }
        public ObservableCollection<ImageSource> images { get; set; }
    }
}
