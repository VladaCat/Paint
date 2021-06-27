using RestSharp;
using RestSharp.Serialization.Json;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Net
{
    class UserAutorizationRequest : IUserAutorizationRequest
    {
        private UserAutorizationData _userAutorizationData;
        private string _paintServerUrl;
        private IRestClient _restClient;
        public AutorizationResultData LastAutorizationResultData { get; private set; }
        public HttpStatusCode LastHttpStatusCode { get; private set; }
        public UserAutorizationRequest(UserAutorizationData userAutorizationData, string paintServerUrl)
        {
            _userAutorizationData = userAutorizationData;
            _paintServerUrl = paintServerUrl;
        }
        public bool Execute()
        {


            var request = new RestRequest { Resource = $"{_paintServerUrl}/auth/login", Method = Method.POST };


            request.AddJsonBody(_userAutorizationData);

            _restClient = new RestClient();
            var response = _restClient.Execute(request);

            LastHttpStatusCode = response.StatusCode;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    var autorizationResultData = new JsonSerializer().Deserialize<AutorizationResultData>(response);

                    LastAutorizationResultData = autorizationResultData;

                    if (autorizationResultData.AutorizationResultCode == 200)
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
                    LastAutorizationResultData = null;
                    return false;
                }
                
            }
            else
            {
                LastAutorizationResultData = null;
                return false;
            }



        }
    }
}
