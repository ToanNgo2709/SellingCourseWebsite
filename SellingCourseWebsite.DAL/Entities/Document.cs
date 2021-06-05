using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("CourseDocument")]
    public class Document
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("document_url")]
        public string DocumentUrl { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        [Column("course_id")]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
