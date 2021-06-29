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
    //public class GetFilesListRequest : IGetFilesListRequest
    //{
    //    private GetFilesListInfo _getFilesListInfo;
    //    private string _paintServerUrl;
    //    private IRestClient _restClient;
    //    public GetFilesListResultData LastGetFilesListResultData { get; private set; }
    //    public HttpStatusCode LastHttpStatusCode { get; private set; }

    //    public GetFilesListRequest(GetFilesListInfo getFilesListInfo, string paintServerUrl)
    //    {
    //        _getFilesListInfo = getFilesListInfo;
    //        _paintServerUrl = paintServerUrl;
    //    }

    //    public bool Execute()
    //    {
    //        var request = new RestRequest { Resource = $"{_paintServerUrl}/operation/getsavedfileslist", Method = Method.POST };


    //        request.AddJsonBody(_getFilesListInfo);

    //        _restClient = new RestClient();
    //        var response = _restClient.Execute(request);

    //        LastHttpStatusCode = response.StatusCode;
    //        if (response.StatusCode == HttpStatusCode.OK)
    //        {
    //            try
    //            {
    //                var getFilesListResultData = new JsonSerializer().Deserialize<GetFilesListResultData>(response);

    //                LastGetFilesListResultData = getFilesListResultData;

    //                if (getFilesListResultData.GetFilesListResult == true)
    //                {
    //                    return true;
    //                }
    //                else
    //                {
                        
    //                    return false;
    //                }

    //            }
    //            catch
    //            {
    //                LastGetFilesListResultData = null;
    //                return false;
    //            }

    //        }
    //        else
    //        {
    //            LastGetFilesListResultData = null;
    //            return false;
    //        }
    //    }
    //}
}
