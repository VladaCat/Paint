﻿using RestSharp;
using RestSharp.Serialization.Json;
using System.Net;

namespace Team_Project_Paint.Net
{
    public class RequestBase<REQUESTTYPE, RESPONCETYPE>
    {
        
        protected string _paintServerUrl;
        protected string _paintServiceUrl;
        protected REQUESTTYPE _requestDTO;
        public HttpStatusCode LastHttpStatusCode { get; private set; }
        public RESPONCETYPE LastResponceDTO { get; private set; }
       
        public RequestBase(REQUESTTYPE requestDTO, string paintServerUrl)
            {
                 _paintServerUrl = paintServerUrl;
            }

        public virtual HttpStatusCode Execute()
        {
            var request = new RestRequest { Resource = $"{_paintServerUrl}{_paintServiceUrl}", Method = Method.POST };
            request.AddJsonBody(_requestDTO);
            RestClient restClient = new RestClient();
            var response = restClient.Execute(request);
            LastHttpStatusCode = response.StatusCode;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    LastResponceDTO = new JsonSerializer().Deserialize<RESPONCETYPE>(response);
                    return response.StatusCode;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            else
            {// responce HTTP status is not 200
                //TODO CHANGE!!!!
                return response.StatusCode;
            }
        }
    }
}
