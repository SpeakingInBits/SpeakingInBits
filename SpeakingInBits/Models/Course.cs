using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakingInBits.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        public List<Lesson> Lessons { get; set; }
    }
}
