using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("CourseQuestion")]
    public class Question
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("course_id")]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Column("reply_user_id")]
        [ForeignKey("UserInfo")]
        public int ReplyUserId { get; set; }
        public UserInfo UserInfo { get; set; }

        [Column("message")]
        public string Message { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}
