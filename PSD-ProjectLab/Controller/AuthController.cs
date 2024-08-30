using PSD_ProjectLab.Handler;
using PSD_ProjectLab.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace PSD_ProjectLab.Controller
{
    public class AuthController
    {
        public static Response<User> validateLogin(String username, String password)
        {
            if (username == "" || password == "")
            {
                return new Response<User>
                {
                    Success = false,
                    Message = "All Field must be Filled!",
                    Payload = null
                };
            }
            Response<User> response = UserHandler.doLogin(username, password);
            return response;
        }

        public static String validateRegister(String username, String email, String password, String confirm, String gender, DateTime date)
        {
            if (username != "")
            {
                if(username.Length>=5 && username.Length < 15)
                {
                    String response = UserHandler.checkUsernameRegister(username);
                    if(response == "False")
                    {
                        return "Username already exist, please pick another name!";
                    }
                }
                else
                {
                    return "Username length must be between 5 and 15 words";
                }
            }
            else
            {
                return "Username Cannot be Empty";
            }

            if (!email.EndsWith(".com") || email == "")
            {
                return "Email must ends with .com and cannot be empty!";
            }

            if (gender == "")
            {
                return "Please pick a gender!";
            }

            if(password!=confirm || password=="" || !IsAlphanumeric(password))
            {
                return "Password must be the same as confirm pass, cannot be empty, and must be alphanumeric!";
            }

            if(confirm != password || confirm == "")
            {
                return "Confirm Password must be the same as Password, and cannot be empty";
            }

            if(date == null || date>DateTime.Now)
            {
                return "DOB cannot be empty and cannot be in the future!";
            }
            UserHandler.doRegister(username, email, password, confirm, gender, date);
            return "ok";
        }

        public static String updateProfile(int id,String username, String email, String gender, DateTime date)
        {
            if (username != "")
            {
                if (username.Length >= 5 && username.Length < 15)
                {
                    
                }
                else
                {
                    return "Username length must be between 5 and 15 words";
                }
            }
            else
            {
                return "Username Cannot be Empty";
            }

            if (!email.EndsWith(".com") || email == "")
            {
                return "Email must ends with .com and cannot be empty!";
            }

            if (gender == "")
            {
                return "Please pick a gender!";
            }
            if (date == null || date > DateTime.Now)
            {
                return "DOB cannot be empty and cannot be in the future!";
            }
            UserHandler.updateProfile(id,username, email, gender, date);
            return "ok";
        }

        public static String updatePassword(int id,String dbPass,String oldPass,String newPass, String confirm)
        {
            if(oldPass == "" || newPass == "" || confirm == "")
            {
                return "All Field Must be Filled!";
            }
            else if(dbPass != oldPass)
            {
                return "Old Password is not matching!";
            }
            else if(newPass != confirm)
            {
                return "New Password must be the same as Confirm New Password";
            }
            else if(newPass == oldPass)
            {
                return "New Password cannot be the same as Old Password";
            }
            UserHandler.updatePassword(id, newPass);
            return "ok";
        }

        private static bool IsAlphanumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}