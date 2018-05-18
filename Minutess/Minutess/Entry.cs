﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Minutess
{
    public class Entry
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public override string ToString()
        {
            return Title + " " + CreateDate;
        }
    }
}
