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
   //public class StatisticRequest
   // {
   //     private StatisticInfo _statisticInfo;
   //     private string _paintServerUrl;
   //     private IRestClient _restClient;
   //     public StatisticResultData LastStatisticResultData { get; private set; }
   //     public HttpStatusCode LastHttpStatusCode { get; private set; }

   //     public StatisticRequest(StatisticInfo statisticInfo, string paintServerUrl)
   //     {
   //         _statisticInfo = statisticInfo;
   //         _paintServerUrl = paintServerUrl;
   //     }

   //     public bool Execute()
   //     {
   //         var request = new RestRequest { Resource = $"{_paintServerUrl}/operation/getuserstatistic", Method = Method.POST };


   //         request.AddJsonBody(_statisticInfo);

   //         _restClient = new RestClient();
   //         var response = _restClient.Execute(request);

   //         LastHttpStatusCode = response.StatusCode;
   //         if (response.StatusCode == HttpStatusCode.OK)
   //         {
   //             try
   //             {
   //                 var getStatisticResultData = new JsonSerializer().Deserialize<StatisticResultData>(response);

   //                 LastStatisticResultData = getStatisticResultData;

   //                 if (getStatisticResultData.StatisticResult == true)
   //                 {
   //                     return true;
   //                 }
   //                 else
   //                 {

   //                     return false;
   //                 }

   //             }
   //             catch
   //             {
   //                 LastStatisticResultData = null;
   //                 return false;
   //             }

   //         }
   //         else
   //         {
   //             LastStatisticResultData = null;
   //             return false;
   //         }
   //     }
   // }
}
