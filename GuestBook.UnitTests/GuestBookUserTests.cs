using GuestBook.Controllers;
using GuestBook.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuestBook.UnitTests
{
 
    [TestClass]
    public class GuestBookUserTests
    {

        [TestMethod]
        public void GetFullName_CapitalLetter_returnsTrue()
        {
            GuestBookUser user = new GuestBookUser(1, "adham", "1234", "adham", "hossam");
            string captialname = "Adham Hossam";
            Assert.IsTrue(captialname == user.getFullName());
        }

        [TestMethod]
        public void GetFullName_SmallLetter_returnsFalse()
        {
            GuestBookUser user = new GuestBookUser(1, "adham", "1234", "adham", "hossam");
            string captialname = "Adham hossam";
            Assert.IsFalse(captialname == user.getFullName());
        }
        [TestMethod]
        public void CapitalizeName_CapitalLetter_returnsTrue()
        {
            GuestBookUser user = new GuestBookUser(1, "adham", "1234", "adham", "hossam");

           
            string captialname = "Sayed";
            Assert.IsTrue(captialname == user.CapitalizeFirstLetter("sayed"));
        }
        public void CapitalizeName_SmallLetter_returnsFalse()
        {
            GuestBookUser user = new GuestBookUser(1, "adham", "1234", "adham", "hossam");


            string captialname = "sayed";
            Assert.IsFalse(captialname == user.CapitalizeFirstLetter("sayed"));
        }
    }
}
