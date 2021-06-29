
namespace Team_Project_Paint.Net
{
    class SaveImageRequestGen<REQUESTTYPE, RESPONCETYPE> : RequestBase<REQUESTTYPE, RESPONCETYPE>
    {
        public SaveImageRequestGen(REQUESTTYPE requestDTO, string paintServerUrl)
            : base(requestDTO, paintServerUrl)
        {
            _paintServerUrl = paintServerUrl;
            _paintServiceUrl = "/operation/save";
        }
    }
}
