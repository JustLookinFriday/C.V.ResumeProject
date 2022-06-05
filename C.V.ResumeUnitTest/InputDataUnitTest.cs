using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace C.V.ResumeUnitTest
{
    [TestClass]
    public class InputDataUnitTest
    {
        /// <summary>
        /// Проверка на пустую строку
        /// </summary>
        [TestMethod]
        public void EmtpyString_Correct()
        {
            //Arrange
            string nullsrt = "";
            string exp = String.Empty;
            //Act

            //Assert
            Assert.AreEqual(nullsrt, exp);
        }

        /// <summary>
        /// Проверка на не пустую строку
        /// </summary>
        [TestMethod]
        public void EmtpyString_NoCorrect()
        {
            //Arrange
            string nullsrt = "Hello!";
            string exp = String.Empty;
            //Act

            //Assert
            Assert.AreNotEqual(nullsrt, exp);
        }

        /// <summary>
        /// Проверка на корректную почту
        /// </summary>
        [TestMethod]
        public void Email_Correct()
        {
            //Arrange
            string email = "example@mail.com";
            string enter = @"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})$";
            //Act
            Regex rgx = new Regex(enter);
            bool test = rgx.Match(email).Success;
            //Assert
            Assert.IsTrue(test);
        }

        /// <summary>
        /// Проверка на не корректную почту
        /// </summary>
        [TestMethod]
        public void Email_NoCorrect()
        {
            //Arrange
            string email = "example@000mail.com";
            string enter = @"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})$";
            //Act
            Regex rgx = new Regex(enter);
            bool test = rgx.Match(email).Success;
            //Assert
            Assert.IsFalse(test);
        }

        /// <summary>
        /// Проверка на корректный номер
        /// </summary>
        [TestMethod]
        public void Phone_Correct()
        {
            //Arrange
            string phone = "8 (999) 123-45-64";
            string enter = @"(^[\d]{1}\ \([\d]{2,3}\)\ [\d]{2,3}-[\d]{2,3}-[\d]{2,3}$)";
            //Act
            Regex rgx = new Regex(enter);
            bool test = rgx.Match(phone).Success;
            //Assert
            Assert.IsTrue(test);
        }

        /// <summary>
        /// Проверка на не корректный номер
        /// </summary>
        [TestMethod]
        public void Phone_NoCorrect()
        {
            //Arrange
            string phone = "89991234564";
            string enter = @"(^[\d]{1}\ \([\d]{2,3}\)\ [\d]{2,3}-[\d]{2,3}-[\d]{2,3}$)";
            //Act
            Regex rgx = new Regex(enter);
            bool test = rgx.Match(phone).Success;
            //Assert
            Assert.IsFalse(test);
        }

        /// <summary>
        /// Проверка на корректное не имя файла
        /// </summary>
        [TestMethod]
        public void FileName_Correct()
        {
            //Arrange
            string file = "fsdffsdfs.png";
            string enter = @"([^\s]+(?=\.(jpg|gif|png))\.\2)";
            //Act
            Regex rgx = new Regex(enter);
            bool test = rgx.Match(file).Success;
            //Assert
            Assert.IsTrue(test);
        }

        /// <summary>
        /// Проверка на корректное не имя файла
        /// </summary>
        [TestMethod]
        public void FileName_NoCorrect()
        {
            //Arrange
            string file = "fsdffsdfs.svg";
            string enter = @"([^\s]+(?=\.(jpg|gif|png))\.\2)";
            //Act
            Regex rgx = new Regex(enter);
            bool test = rgx.Match(file).Success;
            //Assert
            Assert.IsFalse(test);
        }
    }
}
