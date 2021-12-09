using GuestBook.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace GuestBook.UnitTests
{
    [TestClass]
    public class FieldValidatorTests

    {
        [TestMethod]
        public void ValidateUsernameStructure_LetterAndNumberStructure_returnsTrue()
        {
            string username = "adham12";

            bool result = FieldValidator.ValidateUsernameStructure(username);

            Assert.IsTrue(result);



        }
        [TestMethod]
        public void ValidateUsernameStructure_LetterAndNumberCharectersStructure_returnsFalse()
        {
            string username = "adham12*_";

            bool result = FieldValidator.ValidateUsernameStructure(username);

            Assert.IsFalse(result);



        }
        [TestMethod]
        public void ValidateUsernameStructure_EmptyStructure_returnsFalse()
        {
            string username = "";

            bool result = FieldValidator.ValidateUsernameStructure(username);

            Assert.IsFalse(result);



        }
        [TestMethod]
        public void ValidateNameStructure_LetterOnly_returnsTrue()
        {
            string name = "adham";

            bool result = FieldValidator.ValidateNameStructure(name);

            Assert.IsTrue(result);



        }
        [TestMethod]
        public void ValidateNameStructure_LetterAndNumber_returnsFalse()
        {
            string name = "adham1";

            bool result = FieldValidator.ValidateNameStructure(name);

            Assert.IsFalse(result);



        }
        [TestMethod]
        public void ValidateNameStructure_Empty_returnsFalse()
        {
            string name = "";

            bool result = FieldValidator.ValidateNameStructure(name);

            Assert.IsFalse(result);



        }
        [TestMethod]
        public void ValidatePasswordStructure_TooShort_returnsFalse()
        {
            string password = "a";

            bool result = FieldValidator.ValidatePasswordStructure(password);

            Assert.IsFalse(result);



        }
        [TestMethod]
        public void ValidatePasswordStructure_Empty_returnsFalse()
        {
            string password = "               ";

            bool result = FieldValidator.ValidatePasswordStructure(password);

            Assert.IsFalse(result);



        }
        [TestMethod]
        public void ValidatePasswordStructure_Normal_returnsTrue()
        {
            string password = "adham12345";

            bool result = FieldValidator.ValidatePasswordStructure(password);

            Assert.IsTrue(result);



        }
        [TestMethod]
        public void ValidateIsEmpty_Empty_returnsTrue()
        {
            string text= "";

            bool result = FieldValidator.isEmptyOrNull(text);

            Assert.IsTrue(result);



        }
        [TestMethod]
        public void ValidateVerfiyPassword_Equal_returnsTrue()
        {
            string text = "123";
            string text2 = "123";
            bool result = FieldValidator.VerifyPassword(text, text2);

            Assert.IsTrue(result);



        }
        [TestMethod]
        public void ValidateVerfiyPassword_Equal_returnsFalse()
        {
            string text = "123";
            string text2 = "1234";
            bool result = FieldValidator.VerifyPassword(text, text2);

            Assert.IsFalse(result);



        }
    }
}
