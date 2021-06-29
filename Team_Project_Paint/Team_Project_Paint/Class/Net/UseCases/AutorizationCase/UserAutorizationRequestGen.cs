
namespace Team_Project_Paint.Net
{
    class UserAutorizationRequestGen<REQUESTTYPE, RESPONCETYPE> : RequestBase<REQUESTTYPE, RESPONCETYPE>
    {
        public UserAutorizationRequestGen(REQUESTTYPE requestDTO, string paintServerUrl)
            : base(requestDTO, paintServerUrl)
        {
            _paintServerUrl = paintServerUrl;
            _paintServiceUrl = "/auth/login";
        }
    }
}
