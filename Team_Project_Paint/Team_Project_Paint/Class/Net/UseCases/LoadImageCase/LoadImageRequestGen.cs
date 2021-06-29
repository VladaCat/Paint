
namespace Team_Project_Paint.Net
{
    class LoadImageRequestGen<REQUESTTYPE, RESPONCETYPE> : RequestBase<REQUESTTYPE, RESPONCETYPE>
    {
        public LoadImageRequestGen(REQUESTTYPE requestDTO, string paintServerUrl)
            : base(requestDTO, paintServerUrl)
        {
            _paintServerUrl = paintServerUrl;
            _paintServiceUrl = "/operation/load";
        }
    }
}
