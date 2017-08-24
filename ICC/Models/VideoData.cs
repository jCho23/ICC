using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ICC.Models
{
    public class VideoData
    {
        public string Name { get; set; }
        public string VideoUrl { get; set; }
        public TimeSpan VideoDuration { get; set; }
    }
}