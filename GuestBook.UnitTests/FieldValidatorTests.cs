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
    }
}
