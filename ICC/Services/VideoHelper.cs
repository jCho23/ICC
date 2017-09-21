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
			VideoData tempObject;

            tempObject = new VideoData() { 
                fileName = "june's test video + datetime string",
                title = "june's test video",
                mediaAssetUri = "https://xamcamstorage.blob.core.windows.net/asset-ace2bd21-69a0-4875-b32a-3f8ce925791c/0300F2B40800E0C00500A1210500553105000AF4060001000400901B0400B62F040028C601005C8F02008EAB09001C17-636404069661356035.mp4"
            };


			var url = "http://iccfunction.azurewebsites.net/api/GetMediaAssets";
            var response = await client.GetStringAsync(url);

			var intermediateList = JsonConvert.DeserializeObject<List<VideoData>>(response);
            intermediateList.Add(tempObject);


            //			return JsonConvert.DeserializeObject<List<VideoData>>(response);
            return intermediateList;
		}
    }
}