using NUnit.Framework;

using Team_Project_Paint.Helpers;

namespace PaintTests
{
    public class ValidationTests
    {
        private Validation _validation;

        [SetUp]
        public void Setup()
        {
            _validation = new Validation();
        }

        [TestCase("djueiedk@gmail.com", true)]
        [TestCase("dkdoefjr@uuu.com.ua", true)]
        [TestCase("djdjwa_dmw@gmail.com", true)]
        [TestCase("jkojn.odoe@gmail.com", true)]
        [TestCase("FDKedksa@gmail.com", true)]
        [TestCase("KFJFKD@GMAIL.COM", true)]
        [TestCase("47392853@gmail-kz.com", true)]
        [TestCase("fkddkeolds", false)]
        [TestCase("fjdked@ffkdo", false)]
        [TestCase("ddslowsk@@.gamil.com", false)]
        [TestCase("@dkdke.com", false)]
        [TestCase("fjfkdie@gmail..com", false)]
        [TestCase("fkdeoeld..d@mail.ru", false)]
        [TestCase(".dkeejdk@gmail.com", false)]
        [TestCase("gkfkf.e@com", false)]
        [TestCase("fjfkdie.@gmail.com", false)]
        public void ValidationEmail(string email, bool exp)
        {
            var act = _validation.EmailValidate(email);

            Assert.AreEqual(exp, act);
        }


        [TestCase("Dima", true)]
        [TestCase("Yan", true)]
        [TestCase("Li", true)]
        [TestCase("Kldkekdjskdiedjdkfjdkdiedksjsk", true)]
        [TestCase("iPhone7", true)]
        [TestCase("Andrey-Leonid", true)]
        [TestCase("Alla-Viktoria", true)]
        [TestCase("A", false)]
        [TestCase("Kldkekdjskdiedjdkfjdkdiedksjskw", false)]
        [TestCase("", false)]
        public void ValidationFirstAndLastNAme(string password, bool exp)
        {
            var act = _validation.FirstLastNameValidation(password);

            Assert.AreEqual(exp, act);
        }


        [TestCase("Qq123456", true, "Ok")]
        [TestCase("0_.594>Aa", true, "Ok")]
        [TestCase("12345678Aa", true, "Ok")]
        [TestCase("QWERty12", true, "Ok")]
        [TestCase("P@$$w0rdQ", true, "Ok")]
        [TestCase("AQWSedfjgut47386", true, "Ok")]
        [TestCase("YTR fkd21", true, "Ok")]
        [TestCase("98854", false, "Пароль должен иметь длину от 8 до 16 символов.")]
        [TestCase("aB2dsa", false, "Пароль должен иметь длину от 8 до 16 символов.")]
        [TestCase("89fjsD3jslascjd$2", false, "Пароль должен иметь длину от 8 до 16 символов.")]
        [TestCase("98745845", false, "Пароль должен содержать как минимум одну строчую букву.")]
        [TestCase("12345678r", false, "Пароль должен содержать как минимум 1 заглавную букву.")]
        [TestCase("djedjskwD", false, "Пароль должен содержать как минимум одну цифру.")]


        public void ValidationPassword2(string password, bool exp, string exp1)
        {

            (bool actbool, string stringAct) = _validation.PasswordValidate(password);

            Assert.AreEqual(exp, actbool);
            Assert.AreEqual(exp1, stringAct);

        }

    }
}
