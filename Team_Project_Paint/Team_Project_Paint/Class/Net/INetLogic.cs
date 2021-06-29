
namespace Team_Project_Paint.Net
{
    public interface INetLogic
    {
        string PaintServerUrl { get; set; }

        int UserID { get; }
        string Login { get; }
        string FirstName { get; }
        string LastName { get; }


        BoolStringType AutorizeUserGen(UserAutorizationData userAutorizationData);
        BoolStringType RegisterUserGen(UserRegistrationData userRegistrationData);
        BoolStringType SaveImageGen(SaveImageInfo saveImageInfo);
    }
}
