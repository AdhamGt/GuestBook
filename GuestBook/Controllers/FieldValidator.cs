using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GuestBook.Controllers
{
    public class FieldValidator
    {


        public static bool ValidateUsernameStructure(string username)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (regexItem.IsMatch(username) && !username.Contains(" ") && !isEmptyOrNull(username))
            {
                return true;
            }
          
            return false;
        }
        public static bool ValidateNameStructure(string name)
        {
            var regexItem = new Regex("^[a-zA-Z]*$");

            if (regexItem.IsMatch(name) && !name.Contains(" ")  && !isEmptyOrNull(name))
            {
                return true;
            }
            return false;
        }
       public static bool isEmptyOrNull(string text)
        {
            if(string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            return false;
        }
        public static bool ValidatePasswordStructure(string password)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (password.Length > 3 && password.Length < 30)
            {
                if (regexItem.IsMatch(password) && !password.Contains(" "))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool VerifyPassword(string password , string confirmpassword)
        {

            if(password == confirmpassword)
            {
                return true;
            }
            return false;
        }

    }
}
