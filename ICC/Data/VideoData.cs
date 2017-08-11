using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ICC.Data
{
    public class VideoData : ContentPage
    {
        public class VideoData
        {
            public static ObservableCollection<string> ObeservableStringList = new ObservableCollection<string>
            {
                "1","2","3"
            };

        };
    }
}

