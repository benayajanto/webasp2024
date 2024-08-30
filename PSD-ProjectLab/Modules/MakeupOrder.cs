using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Modules
{
    public class MakeupOrder
    {
        public int MakeupId { get; set; }
        public string MakeupName { get; set; }
        public int MakeupPrice { get; set; }
        public int MakeupWeight { get; set; }
        public string MakeupTypeName { get; set; }
        public string MakeupBrandName { get; set; }
    }
}