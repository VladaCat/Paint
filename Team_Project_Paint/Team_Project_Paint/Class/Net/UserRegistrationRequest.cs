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
    public class UserRegistrationRequest : IUserRegistrationRequest
    {

        private UserRegistrationData _userRegistrationData;

        private string _paintServerUrl;
        private IRestClient _restClient;
        public RegistrationResultData LastReistrationResultData { get; private set; }
        public HttpStatusCode LastHttpStatusCode { get; private set; }
        public UserRegistrationRequest(UserRegistrationData userRegistrationData, string paintServerUrl)
        {
            _userRegistrationData = userRegistrationData;
            _paintServerUrl = paintServerUrl;
        }


        public bool Execute()
        {
            var request = new RestRequest { Resource = $"{_paintServerUrl}/auth/register", Method = Method.POST };


            request.AddJsonBody(_userRegistrationData);

            _restClient = new RestClient();
            var response = _restClient.Execute(request);

            LastHttpStatusCode = response.StatusCode;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    var registrationResultData = new JsonSerializer().Deserialize<RegistrationResultData>(response);

                    LastReistrationResultData = registrationResultData;

                    if (registrationResultData.RegistrationResult == true)
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
                    LastReistrationResultData = null;
                    return false;
                }
            }
            else
            {
                LastReistrationResultData = null;
                return false;
            }
        }
    }
}
