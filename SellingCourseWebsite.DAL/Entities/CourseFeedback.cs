using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("CourseFeedBack")]
    public class CourseFeedback
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("content")]
        public string Content { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("course_id")]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}
