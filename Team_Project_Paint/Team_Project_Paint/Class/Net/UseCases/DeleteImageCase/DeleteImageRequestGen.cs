
namespace Team_Project_Paint.Net
{
    class DeleteImageRequestGen<REQUESTTYPE, RESPONCETYPE> : RequestBase<REQUESTTYPE, RESPONCETYPE>
    {
        public DeleteImageRequestGen(REQUESTTYPE requestDTO, string paintServerUrl)
            : base(requestDTO, paintServerUrl)
        {
            _paintServerUrl = paintServerUrl;
            _paintServiceUrl = "/operation/delete";
        }
    }
}
