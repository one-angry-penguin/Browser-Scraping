﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class WordCount : IEntity
    {
        public Guid Id { get; set; }
        public Guid WebpageId { get; set; }
        public Webpage Webpage { get; set; }
        public string Value { get; set; }
        public int Count { get; set; }
    }
}