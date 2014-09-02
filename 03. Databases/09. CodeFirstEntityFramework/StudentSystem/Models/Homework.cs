using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem
{
    public class Homework
    {
        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }

        [Key]
        public int HomeworkId { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime? TimeSent { get; set; }
    }
}
