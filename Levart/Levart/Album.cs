using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Levart
{
    public class Album
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static ObservableCollection<Entry> entryList;
    }
}
