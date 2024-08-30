using PSD_ProjectLab.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Controller
{
    public class MakeUpBrandController
    {
        public static String insertMakeUpBrand(String name, int rating)
        {
            if (name.Length < 1 || name.Length > 99)
            {
                return "Length must be between 1 - 99 characters!";
            }
            else if(rating < 0 || rating >100)
            {
                return "Rating must be between 0 adn 100";
            }
            MakeUpBrandHandler.insertMakeUpBrand(name, rating);
            return "ok";
        }

        public static String updateMakeupBrand(int id, String name, int rating)
        {
            if (name.Length < 1 || name.Length > 99)
            {
                return "Length must be between 1 - 99 characters!";
            }
            else if (rating < 0 || rating > 100)
            {
                return "Rating must be between 0 adn 100";
            }
            MakeUpBrandHandler.updateMakeUpBrand(id,name, rating);
            return "ok";
        }
    }
}