using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Handler
{
    public class MakeUpBrandHandler
    {
        public static void insertMakeUpBrand(String name, int rating)
        {
            MakeUpBrandRepo.insertMakeUpBrand(name, rating);
        }

        public static void updateMakeUpBrand(int id, String name, int rating)
        {
            MakeUpBrandRepo.updateMakeupBrand(id, name, rating);
        }
    }
}