

namespace Team_Project_Paint.Net
{
    class UserRegistrationRequestGen<REQUESTTYPE, RESPONCETYPE> : RequestBase<REQUESTTYPE, RESPONCETYPE>
    {
        public UserRegistrationRequestGen(REQUESTTYPE requestDTO, string paintServerUrl)
            :base(requestDTO, paintServerUrl)
        {
            _paintServerUrl = paintServerUrl;
            _paintServiceUrl = "/auth/register";
        }
    }
}
