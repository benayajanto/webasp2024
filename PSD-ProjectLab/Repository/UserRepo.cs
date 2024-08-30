using PSD_ProjectLab.Factory;
using PSD_ProjectLab.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Repository
{
    public class UserRepo
    {
        private static Database1Entities db = DatabaseManager.getInstance();

        public static User getUser(string username, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.Username == username && u.UserPassword == password);
            if (user == null)
            {
                return null;
            }
            return user;
        }
        public static List<User> GetAllUser()
        {
            return db.Users.ToList();
        }
        public static User getUserbyUsername(string username)
        {
            var user = db.Users.FirstOrDefault(u => u.Username == username);
            if (user!=null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public static User getUserbyID(int id)
        {
            User user = (from x in db.Users where x.UserID == id select x).FirstOrDefault();
            return user;
        }

        public static void createUser(String username, String email, String password, String confirm, String gender, DateTime date)
        {
            int lastID = (from x in db.Users select x.UserID).ToList().LastOrDefault();
            if (lastID == 0)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }
            User user = null;
            if(username == "admin")
            {
                user = UserFactory.CreateAdmin(lastID, username, email, password, gender, date);
            }
            else
            {
                user = UserFactory.Create(lastID, username, email, password, gender, date);
            }

            db.Users.Add(user);
            db.SaveChanges();
        }

        public static void updateProfile(int id,String username, String email, String gender, DateTime date)
        {
            User user = (from x in db.Users where x.UserID == id select x).FirstOrDefault();
            user.Username = username;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserDOB = date;
            db.SaveChanges();
        }

        public static void updatePassword(int id,String newPass)
        {
            User user = (from x in db.Users where x.UserID == id select x).FirstOrDefault();
            user.UserPassword = newPass;
            db.SaveChanges();
        }

    }
}