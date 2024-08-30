using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Factory
{
    public class UserFactory
    {
        public static User Create(int userID,String username, String email, String password, String gender, DateTime date)
        {
            User user = new User();
            user.UserID = userID;
            user.Username = username;
            user.UserEmail = email;
            user.UserDOB = date;
            user.UserGender = gender;
            user.UserRole = "Customer";
            user.UserPassword = password;
            return user;
        }

        public static User CreateAdmin(int userID, String username, String email, String password, String gender, DateTime date)
        {
            User user = new User();
            user.UserID = userID;
            user.Username = username;
            user.UserEmail = email;
            user.UserDOB = date;
            user.UserGender = gender;
            user.UserRole = "Admin";
            user.UserPassword = "admin";
            return user;
        }
    }
}