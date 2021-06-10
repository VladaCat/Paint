

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

        public static string txtIncorrectPassword
        { get => "Пароль неприемлем. Пароль должен иметь длину от 8 до 16 символов, должен содержать как минимум 1 заглавную букву, одну строчую букву и 1 цифру"; }

        public static string txtDiferentPasswords
        { get => "Введенные пароли не совпадают"; }

        public static string txtConfirmSaveOnExit
        { get => "Вы уверены, что хотите выйти, не сохранив предварительно рисунок?"; }










    }
}
