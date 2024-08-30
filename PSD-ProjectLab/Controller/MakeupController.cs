using PSD_ProjectLab.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Controller
{
    public class MakeupController
    {
        public static String insertMakeup(String name, int price, int weight, int typeId, int brandId)
        {
            if (name.Length < 1 || name.Length > 99)
            {
                return "Length must be between 1 - 99 characters!";
            }
            else if (price < 0)
            {
                return "Price must be more than 0";
            }
            else if (weight < 0 || weight > 1500)
            {
                return "Weight cannot be less than 0 and more than 1500 (in grams)";
            }
            else
            {
                String response = MakeupHandler.insertMakeup(name,price, weight, typeId,brandId);
                return response;
            }
        }

        public static String updateMakeup(int id,String name, int price, int weight, int typeId, int brandId)
        {
            if (name.Length < 1 || name.Length > 99)
            {
                return "Length must be between 1 - 99 characters!";
            }
            else if (price < 0)
            {
                return "Price must be more than 0";
            }
            else if (weight < 0 || weight > 1500)
            {
                return "Weight cannot be less than 0 and more than 1500 (in grams)";
            }
            else
            {
                String response = MakeupHandler.updateMakeup(id,name, price, weight, typeId, brandId);
                return response;
            }
        }
    }
}