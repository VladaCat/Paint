using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Net
{
    public interface INetLogic
    {
        string PaintServerUrl { get; set; }

        int UserID { get; }
        string Login { get; }
        string FirstName { get; }
        string LastName { get; }

        bool AutorizeUser(UserAutorizationData userAutorizationData);

        bool RegisterUser(UserRegistrationData userRegistrationData);
        bool SaveImage(SaveImageInfo saveImageInfo);
    }
}
