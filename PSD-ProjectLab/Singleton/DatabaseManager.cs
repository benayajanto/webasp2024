using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Singleton
{
    public class DatabaseManager
    {
        private static Database1Entities instance = null;
        public static Database1Entities getInstance()
        {
            if(instance == null)
            {
                instance = new Database1Entities();
            }
            return instance;
        }
    }
}