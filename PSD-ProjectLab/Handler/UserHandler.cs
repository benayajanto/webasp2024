using PSD_ProjectLab.Modules;
using PSD_ProjectLab.Repository;
using PSD_ProjectLab.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Handler
{
    public class UserHandler
    {
        private static Database1Entities db = DatabaseManager.getInstance();
        public static Response<User> doLogin(string username, string password)
        {
            User user = UserRepo.getUser(username, password);
            if (user == null)
            {
                return new Response<User>
                {
                    Success = false,
                    Message = "Invalid Credential",
                    Payload = null
                };
            }
            return new Response<User> { 
                Success = true,
                Message = "",
                Payload = user
            };
        }

        public static String checkUsernameRegister(string username)
        {
            User user = UserRepo.getUserbyUsername(username);
            if(user == null)
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }

        public static void doRegister(String username, String email, String password, String confirm, String gender, DateTime date)
        {
            UserRepo.createUser(username, email, password, confirm, gender, date);
        }

        public static void updateProfile(int id,String username, String email, String gender, DateTime date)
        {
            UserRepo.updateProfile(id, username, email, gender, date);  
        }

        public static void updatePassword(int id, String newPass)
        {
            UserRepo.updatePassword(id, newPass);
        }
    }
}