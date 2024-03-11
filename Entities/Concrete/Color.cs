﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Color:Entity
    {
        public int ColorId { get; set; }
        public string Name { get; set; }
        public string ColorCode { get; set; }
    }
}
