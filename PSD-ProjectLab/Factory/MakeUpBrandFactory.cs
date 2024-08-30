using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Factory
{
    public class MakeUpBrandFactory
    {
        public static MakeUpBrand Create(int id, String name, int rating)
        {
            MakeUpBrand brand = new MakeUpBrand();
            brand.MakeupBrandsID = id;
            brand.MakeupBrandName = name;
            brand.MakeupBrandRating = rating;
            return brand;
        }
    }
}