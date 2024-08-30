using PSD_ProjectLab.Factory;
using PSD_ProjectLab.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Repository
{
    public class MakeUpBrandRepo
    {
        private static Database1Entities db = DatabaseManager.getInstance();
        private static int getId()
        {
            int lastID = (from x in db.MakeUpBrands select x.MakeupBrandsID).ToList().LastOrDefault();
            if (lastID == 0)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }
            return lastID;
        }
        public static void insertMakeUpBrand(String name, int rating)
        {
            int id = getId();
            MakeUpBrand brand = MakeUpBrandFactory.Create(id,name, rating);
            db.MakeUpBrands.Add(brand);
            db.SaveChanges();
        }

        public static List<MakeUpBrand> getAllMakeupBrand()
        {
            return db.MakeUpBrands.OrderByDescending(brand => brand.MakeupBrandRating).ToList();
        }

        public static void removeMakeupBrand(int id)
        {
            MakeUpBrand brand=db.MakeUpBrands.Find(id);
            db.MakeUpBrands.Remove(brand);
            db.SaveChanges();
        }

        public static void updateMakeupBrand(int id, String name, int rating)
        {
            MakeUpBrand brand = db.MakeUpBrands.Find(id);
            brand.MakeupBrandRating = rating;
            brand.MakeupBrandName = name;
            db.SaveChanges();
        }
    }
}