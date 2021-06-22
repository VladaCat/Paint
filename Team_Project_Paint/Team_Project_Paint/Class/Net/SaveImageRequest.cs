using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint.Net;

namespace Team_Project_Paint.Net
{
    public class SaveImageRequest : ISaveImageRequest
    {
       private  SaveImageInfo _saveImageInfo;
        private string _paintServerUrl;
        private IRestClient _restClient;
        public SaveImageResultData LastSaveImageResultData { get; private set; }

        public HttpStatusCode LastHttpStatusCode { get; private set; }

     
        public SaveImageRequest(SaveImageInfo saveImageInfo, string paintServerUrl)
        {
            _saveImageInfo = saveImageInfo;
            _paintServerUrl = paintServerUrl;
        }
        public bool Execute()
        {

            var request = new RestRequest { Resource = $"{_paintServerUrl}/operation/save", Method = Method.POST };


            request.AddJsonBody(_saveImageInfo);

            _restClient = new RestClient();
            var response = _restClient.Execute(request);

            LastHttpStatusCode = response.StatusCode;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    var saveImageResultData = new JsonSerializer().Deserialize<SaveImageResultData>(response);

                    LastSaveImageResultData = saveImageResultData;

                    if (saveImageResultData.SaveImageResult == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch
                {
                    LastSaveImageResultData = null;
                    return false;
                }

            }
            else
            {
                LastSaveImageResultData = null;
                return false;
            }


        }
    }
}
