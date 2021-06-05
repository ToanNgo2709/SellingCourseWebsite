using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_info_id")]
        [ForeignKey("UserInfo")]
        public int UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }

        [Column("course_id")]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }


        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("temp_total")]
        public decimal TempTotal { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
