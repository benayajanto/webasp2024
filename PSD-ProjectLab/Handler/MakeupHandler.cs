using PSD_ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Handler
{
    public class MakeupHandler
    {
        public static String insertMakeup(String name, int price, int weight, int typeId, int brandId)
        {
            if(MakeupRepo.checkMakeUpType(typeId)==null || MakeupRepo.checkMakeUpBrand(brandId) == null)
            {
                return "Make sure to insert existing type id and brand id!";
            }
            MakeupRepo.insertMakeup(name,price, weight, typeId, brandId);
            return "True";
        }

        public static String updateMakeup(int id,String name, int price, int weight, int typeId, int brandId)
        {
            if (MakeupRepo.checkMakeUpType(typeId) == null || MakeupRepo.checkMakeUpBrand(brandId) == null)
            {
                return "Make sure to insert existing type id and brand id!";
            }
            MakeupRepo.updateMakeup(id,name,price,weight, typeId,brandId);
            return "True";
        }
    }
}