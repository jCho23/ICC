using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ICC.Models
{
    public class VideoData
    {
		//public string MediaAssetUri { get; set; }
		//public string MediaAssetName { get; set; }
		public string id { get; set; }
		public string mediaAssetUri { get; set; }
		public string email { get; set; }
		public string fileName { get; set; }
		public object uploadedAt { get; set; }
		public string title { get; set; }
		public object accountType { get; set; }
    }
}