﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Core.Models.Base
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }   
        public DateTime UpdatedDate { get; set;}
    }
}
