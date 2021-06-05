using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("StudentFeedBack")]
    public class StudentFeedback
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("student_name")]
        public string StudentName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("avatar_img_path")]
        public string AvatarImagePath { get; set; }

        [Column("course_id")]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Column("work_study_address")]
        public string WorkStudyAddress { get; set; }

        [Column("content")]
        public string Content { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}
