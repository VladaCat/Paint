
namespace Team_Project_Paint.Net
{
    class StatisticsRequestGen<REQUESTTYPE, RESPONCETYPE> : RequestBase<REQUESTTYPE, RESPONCETYPE>
    {
        public StatisticsRequestGen(REQUESTTYPE requestDTO, string paintServerUrl)
            : base(requestDTO, paintServerUrl)
        {
            _paintServerUrl = paintServerUrl;
            _paintServiceUrl = "/operation/getuserstatistic";
        }
    }
}
