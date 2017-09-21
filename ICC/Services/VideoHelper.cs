using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using ICC.Models;
using Newtonsoft.Json;

namespace ICC.Services
{
    public class VideoHelper
    {
        public VideoHelper()
        {
        }

        static HttpClient client = new HttpClient();

        public static async Task<List<VideoData>> GetAllVideosAsync()
        {
            var url = "http://iccfunction.azurewebsites.net/api/GetMediaAssets";
            var response = await client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<List<VideoData>>(response);
		}
    }
}