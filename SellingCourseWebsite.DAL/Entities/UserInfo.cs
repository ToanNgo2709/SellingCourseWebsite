using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("UserInfo")]
    public class UserInfo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("hash_password")]
        public string HashPassword { get; set; }

        [Column("full_name")]
        public string FullName { get; set; }

        [Column("dob")]
        public DateTime Dob { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("user_type_id")]
        [ForeignKey("UserType")]
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }

        [Column("avatar_img_path")]
        public string AvatarImgPath { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        public ICollection<CourseBasket>  CourseBaskets { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
