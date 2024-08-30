using PSD_ProjectLab.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Controller
{
    public class MakeupTypeController
    {
        public static String insertMakeupType(String name)
        {
            if(name.Length<1 || name.Length > 99)
            {
                return "Length must be between 1 - 99 characters!";
            }
            MakeupTypeHandler.insertMakeupType(name);
            return "ok";
        }

        public static String updateMakeupType(int id,String name)
        {
            if (name.Length < 1 || name.Length > 99)
            {
                return "Length must be between 1 - 99 characters!";
            }
            MakeupTypeHandler.updateMakeupType(id, name);
            return "ok";
        }
    }
}