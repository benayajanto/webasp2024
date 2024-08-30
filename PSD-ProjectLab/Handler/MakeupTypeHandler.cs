using PSD_ProjectLab.Controller;
using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Handler
{
    public class MakeupTypeHandler
    {
        public static void insertMakeupType(String name)
        {
            MakeupTypeRepo.InsertMakeUpType(name);
        }

        public static void updateMakeupType(int id, String name)
        {
            MakeupTypeRepo.updateMakeupType(id, name);
        }
    }
}