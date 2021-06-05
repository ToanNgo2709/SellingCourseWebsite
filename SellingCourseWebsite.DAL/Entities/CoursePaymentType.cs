using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("CoursePaymentType")]
    public class CoursePaymentType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
