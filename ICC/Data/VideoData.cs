using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ICC.Data
{
    public class VideoData : ContentPage
    {
        public class VideoName
        {
            public string Name { get; set; }

        }


        public class VideoDatas
        {
            public static ObservableCollection<string> ObservableStringList = new ObservableCollection<string>
            {
                "1","2","3"
            };

        };
    }
}

