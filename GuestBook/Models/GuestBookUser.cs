using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    public class GuestBookUser
    {
        public int userID;
       public string username;
       public string password;
        public string firstName;
        public string lastName;






        public string CapitalizeFirstLetter(string name)
        {
          
                if (string.IsNullOrEmpty(name))
                {
                    return string.Empty;
                }
              
                return char.ToUpper(name[0]) + name.Substring(1).ToLower();
            
        }
        public string getFullName()
        {
            return CapitalizeFirstLetter(firstName) + " " + CapitalizeFirstLetter(lastName);
        }
        public List<GuestBookMessage> userMessages = new List<GuestBookMessage>();
        public  GuestBookUser(int userID , string username, string password,string firstName , string lastName)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        
            public static GuestBookUser getUser(string username,string password)
        {
            GuestBookDB instance =  GuestBookDB.getInstance();
            DataTable dt = instance.Query("Select * from "+DatabaseFields.UserTable+"Where username = '" + username + "' AND upassword = '" + password+"';");
            if (dt.Rows.Count > 0)
            {
                return new GuestBookUser((int)(dt.Rows[0][DatabaseFields.userID]), dt.Rows[0][DatabaseFields.User_username].ToString(), dt.Rows[0][DatabaseFields.User_password].ToString(),dt.Rows[0][DatabaseFields.User_firstName].ToString(), dt.Rows[0][DatabaseFields.User_lastName].ToString());
            }
            else
            {
                {
                    return null;
                }
            }
            }
        public static bool addUser(string username, string password,string FirstName , string LastName)
        {
            GuestBookDB instance = GuestBookDB.getInstance();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add(DatabaseFields.User_username, username);
            parameters.Add(DatabaseFields.User_password, password);
            parameters.Add(DatabaseFields.User_firstName, FirstName);
            parameters.Add(DatabaseFields.User_lastName, LastName);
            parameters.Add(DatabaseFields.User_isActive, 1);
            int affected = instance.Insert(DatabaseFields.UserTable, parameters);
            if (affected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
