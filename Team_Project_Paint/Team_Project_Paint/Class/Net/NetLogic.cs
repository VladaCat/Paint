using System.Net;

namespace Team_Project_Paint.Net
{
    public class NetLogic : INetLogic
    {
        public string PaintServerUrl { get; set; }
        public int UserID { get; private set; }
        public string Login { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public BoolStringType AutorizeUserGen(UserAutorizationData userAutorizationData)
        {
            var request = new UserAutorizationRequestGen<UserAutorizationData, AutorizationResultData>(userAutorizationData, PaintServerUrl);

            if (request.Execute() == HttpStatusCode.OK)
            {
                
                UserID = request.LastResponceDTO.UserId;
                Login = request.LastResponceDTO.Login;
                FirstName = request.LastResponceDTO.FirstName;
                LastName = request.LastResponceDTO.LastName;
                return new BoolStringType()
                {
                    BooleanValue = true,
                    StringValue = request.LastHttpStatusText
                };
            }
            else
                return new BoolStringType()
                {
                    BooleanValue = false,
                    StringValue = request.LastHttpStatusText
                };
        }

        public BoolStringType RegisterUserGen(UserRegistrationData userRegistrationData)
        {
            var request = new UserRegistrationRequestGen<UserRegistrationData, RegistrationResultData>(userRegistrationData, PaintServerUrl);

                if (request.Execute()==HttpStatusCode.OK)
            {

                return new BoolStringType()
                { BooleanValue = true,
                   StringValue=request.LastHttpStatusText
                };
            }
                else
                return new BoolStringType()
                {
                    BooleanValue = false,
                    StringValue = request.LastHttpStatusText
                };
        }

        public BoolStringType SaveImageGen(SaveImageInfo saveImageInfo)
        {
            var request = new SaveImageRequestGen<SaveImageInfo, SaveImageResultData>(saveImageInfo, PaintServerUrl);
            if (request.Execute() == HttpStatusCode.OK)
            {

                return new BoolStringType()
                {
                    BooleanValue = true,
                    StringValue = request.LastHttpStatusText
                };
            }
            else
                return new BoolStringType()
                {
                    BooleanValue = false,
                    StringValue = request.LastHttpStatusText
                };
        }
    }
}
