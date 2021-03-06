﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STMAPI.ViewModels
{
    public class ObjectViewModel
    {
        public Int32? ObjectId { get; set; }
        public String ProjectName { get; set; }
        public String ObjectName { get; set; }
        public String IdentityType { get; set; }
        public String ObjectValue { get; set; }
        public String CreatedBy { get; set; }
        public String CreatedDate { get; set; }
        public String UpdatedBy { get; set; }
        public String UpdatedDate { get; set; }

    }
}
