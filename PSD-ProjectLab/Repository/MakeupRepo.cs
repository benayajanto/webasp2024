using PSD_ProjectLab.Factory;
using PSD_ProjectLab.Modules;
using PSD_ProjectLab.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace PSD_ProjectLab.Repository
{
    public class MakeupRepo
    {
        private static Database1Entities db = DatabaseManager.getInstance();

        private static int getId()
        {
            int lastID = (from x in db.Makeups select x.MakeupID).ToList().LastOrDefault();
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
        public static void insertMakeup(String name, int price, int weight, int typeId, int brandId)
        {
            int id = getId();
            Makeup makeup = MakeupFactory.Create(id,name,price,weight,typeId,brandId);  
            db.Makeups.Add(makeup);
            db.SaveChanges();
        }

        public static void updateMakeup(int id,String name, int price, int weight, int typeId, int brandId)
        {
            Makeup makeup = db.Makeups.Find(id);
            makeup.MakeupName = name;
            makeup.MakeupPrice = price;
            makeup.MakeupWeight = weight;
            makeup.MakeupTypeID = typeId;
            makeup.MakeupBrandID = brandId;
            db.SaveChanges();
        }

        public static MakeupType checkMakeUpType(int id)
        {
            MakeupType type = db.MakeupTypes.Find(id);
            if (type != null)
            {
                return type;
            }
            else
            {
                return null;
            }
        }


        public static MakeUpBrand checkMakeUpBrand(int id)
        {
            MakeUpBrand brand = db.MakeUpBrands.Find(id);
            if (brand != null)
            {
                return brand;
            }
            else
            {
                return null;
            }
        }

        public static List<Makeup> getAllMakeup()
        {
            return db.Makeups.ToList();
        }

        public static Makeup getMakeupbyId(int id)
        {
            Makeup makeup = db.Makeups.Find(id);
            return makeup;
        }

        public static void removeMakeup(int id)
        {
            Makeup makeup = getMakeupbyId(id);
            db.Makeups.Remove(makeup); 
            db.SaveChanges();
        }

    }
}