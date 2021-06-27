using RestSharp;
using RestSharp.Serialization.Json;
using System.Net;



namespace Team_Project_Paint.Net
{
    public class DeleteImageRequest : IDeleteImageRequest
    {
        private DeleteImageInfo _deleteImageInfo;
        private string _paintServerUrl;
        private IRestClient _restClient;
        public DeleteImageResultData LastDeleteImageResultData { get; private set; }
        public HttpStatusCode LastHttpStatusCode { get; private set; }

        public DeleteImageRequest(DeleteImageInfo deleteImageInfo, string paintServerUrl)
        {
            _deleteImageInfo = deleteImageInfo;
            _paintServerUrl = paintServerUrl;
        }

        public bool Execute()
        {
            var request = new RestRequest { Resource = $"{_paintServerUrl}/operation/delete", Method = Method.POST };


            request.AddJsonBody(_deleteImageInfo);

            _restClient = new RestClient();
            var response = _restClient.Execute(request);

            LastHttpStatusCode = response.StatusCode;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    var deleteImageResultData = new JsonSerializer().Deserialize<DeleteImageResultData>(response);

                    LastDeleteImageResultData = deleteImageResultData;

                    if (deleteImageResultData.LoadImageResult == true)
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
                    LastDeleteImageResultData = null;
                    return false;
                }

            }
            else
            {
                LastDeleteImageResultData = null;
                return false;
            }
        }
    }
}
