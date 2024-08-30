﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_ProjectLab.Factory
{
    public class MakeupTypeFactory
    {
        public static MakeupType Create(int id, String name)
        {
            MakeupType type = new MakeupType();
            type.MakeupTypeID = id;
            type.MakeupTypeName = name;
            return type;
        }
    }
}