using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Net
{
    public class LoadImageRequest : ILoadImageRequest
    {
        private LoadImageInfo _loadImageInfo;
        private string _paintServerUrl;
        private IRestClient _restClient;
        public LoadImageResultData LastLoadImageResultData { get; private set; }
        public HttpStatusCode LastHttpStatusCode { get; private set; }

        public LoadImageRequest(LoadImageInfo loadImageInfo, string paintServerUrl)
        {
            _loadImageInfo = loadImageInfo;
            _paintServerUrl = paintServerUrl;
        }

        public bool Execute()
        {
            var request = new RestRequest { Resource = $"{_paintServerUrl}/operation/load", Method = Method.POST };


            request.AddJsonBody(_loadImageInfo);

            _restClient = new RestClient();
            var response = _restClient.Execute(request);

            LastHttpStatusCode = response.StatusCode;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    var loadImageResultData = new JsonSerializer().Deserialize<LoadImageResultData>(response);

                    LastLoadImageResultData = loadImageResultData;

                    if (loadImageResultData.LoadImageResult == true)
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
                    LastLoadImageResultData = null;
                    return false;
                }

            }
            else
            {
                LastLoadImageResultData = null;
                return false;
            }
        }
    }
}
