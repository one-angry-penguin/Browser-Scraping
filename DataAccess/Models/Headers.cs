﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
     public class Headers
    {
        public Guid Id { get; set; }
        
        public WebPage Webpage { get; set; }

        public int HeaderType { get; set; }

        public string Content { get; set; }
    }
}
