using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint.Class.Helpers;

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

        [TestCase("Qq123456", true)]
        [TestCase("0_.594>Aa", true)]
        [TestCase("12345678Aa", true)]
        [TestCase("QWERty12", true)]
        [TestCase("P@$$w0rdQ", true)]
        [TestCase("AQWSedfjgut47386", true)]
        [TestCase("YTR fkd21", true)]
        [TestCase("12345678", false)]
        [TestCase("Aq1234", false)]
        [TestCase("aqwe1234", false)]
        [TestCase("QWERREWQ", false)]
        [TestCase("QWERTTY3", false)]
        [TestCase("QWERTDASWqawe1235", false)]


        public void ValidationPassword(string password, bool exp)
        {
            var act = _validation.PasswordValidate(password);

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

    }
}
