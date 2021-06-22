using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool AutorizeUser(UserAutorizationData userAutorizationData)
        {
            var request = new UserAutorizationRequest(userAutorizationData, PaintServerUrl);

            if (request.Execute())
            {
                UserID = request.LastAutorizationResultData.UserId;
                Login = request.LastAutorizationResultData.Login;
                FirstName = request.LastAutorizationResultData.FirstName;
                LastName = request.LastAutorizationResultData.LastName;
                return true;
            }
            else
            {
                UserID = 0;
                Login = "";
                FirstName = "";
                LastName = "";
                return false;
            }
        }

        public bool RegisterUser(UserRegistrationData userRegistrationData)
        {
            var request = new UserRegistrationRequest(userRegistrationData, PaintServerUrl);
            if (request.Execute())
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        public bool SaveImage(SaveImageInfo savedImageInfo)
        {
            var request = new SaveImageRequest(savedImageInfo, PaintServerUrl);
            if (request.Execute())
            {
                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
