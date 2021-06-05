using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("job")]
        public string Job { get; set; }

        [Column("current_position")]
        public string CurrentPosition { get; set; }

        [Column("skill")]
        public string Skill { get; set; }

        [Column("teaching_experience")]
        public string TeachingExperience { get; set; }

        [Column("user_info_id")]
        [ForeignKey("UserType")]
        public int UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }

        [Column("active")]
        public bool Active { get; set; }


        public ICollection<Course> Courses { get; set; }
    }
}
