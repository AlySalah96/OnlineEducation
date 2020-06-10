﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Education.Models
{
    public class Stage
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}