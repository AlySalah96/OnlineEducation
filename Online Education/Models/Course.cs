using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_Education.Models
{
    public class Course
    {
        [Key]
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int MaxDegree { get; set; }

        public int MinDegree { get; set; }

        public virtual Stage Stage { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Enroll> Enrolls { get; set; }

        public virtual ICollection<Teach> Teach { get; set; }


    }
}