﻿using System;
using System.Collections.Generic;
using System.Text;

namespace STM.Core.EntityLayer
{
    public class ProjKeyValue
    {

      public Int32? VarId { get; set; }

      public Int32? EntityId { get; set; }

      public Int32? ProjectId { get; set; }

      public Int32? EnvironmentId { get; set; }

      public String VarName { get; set; }

     public String VarValue { get; set; }

     public String CreatedBy { get; set; }

     public DateTime CreatedDate { get; set; }

     public String UpdatedBy { get; set; }
 
     public DateTime UpdatedDate { get; set; }


    }
}
