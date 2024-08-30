using PSD_ProjectLab.Factory;
using PSD_ProjectLab.Singleton;
using PSD_ProjectLab.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Repository
{
    public class MakeupTypeRepo
    {
        private static Database1Entities db = DatabaseManager.getInstance();

        private static int getId()
        {
            int lastID = (from x in db.MakeupTypes select x.MakeupTypeID).ToList().LastOrDefault();
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
        public static void InsertMakeUpType(String name)
        {
            int id = getId();
            MakeupType type = MakeupTypeFactory.Create(id, name);
            db.MakeupTypes.Add(type);
            db.SaveChanges();
        }

        public static void updateMakeupType(int id,String name)
        {
            MakeupType type = db.MakeupTypes.Find(id);
            type.MakeupTypeName = name;
            db.SaveChanges();

        }

        public static List<MakeupType> getAllMakeupType()
        {
            return db.MakeupTypes.ToList();
        }

        public static void removeMakeupType(int id)
        {
            MakeupType type = db.MakeupTypes.Find(id);
            db.MakeupTypes.Remove(type);
            db.SaveChanges();
        }
    }
}