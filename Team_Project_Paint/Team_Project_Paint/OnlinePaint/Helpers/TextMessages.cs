

namespace Team_Project_Paint
{
    public static class TextMessages
    {
        public static string txtNoSuchUser
        { get => "Пользователя с таким логином не существует"; }
        public static string txtInvalidPassword
        { get => "Пароль не соответствует этому логину"; }
        public static string txtDuplicateLogin
        { get => "Такой логин уже есть"; }
        
        // под вопросом
        public static string txtIncorrectLogin
        { get => "Не введен логин, либо логин некорректен. Логин должен быть корректным адресом электронной почты."; }

        public static string txtIncorrectName
        { get => "Имя и фамилия должны быть длиной не менее 2 символов и не более 30 символов"; }

        public static string txtIncorrectPasswordMessage1
        { get => "Пароль должен иметь длину от 8 до 16 символов."; }

        public static string txtIncorrectPasswordMessage2
        { get => "Пароль должен содержать как минимум одну строчую букву."; }

        public static string txtIncorrectPasswordMessage3
        { get => "Пароль должен содержать как минимум 1 заглавную букву."; }

        public static string txtIncorrectPasswordMessage4
        { get => "Пароль должен содержать как минимум одну цифру."; }

        public static string txtIncorrectPasswordMessage5
        { get => "Ok"; }

        public static string txtDiferentPasswords
        { get => "Введенные пароли не совпадают"; }

        public static string txtConfirmSaveOnExit
        { get => "Все несохраненные изменения будут потеряны.Вы уверены, что хотите выйти?"; }










    }
}
