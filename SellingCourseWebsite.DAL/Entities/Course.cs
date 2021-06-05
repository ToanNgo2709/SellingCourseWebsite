using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }

        [Column("teacher_id")]
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }


        [Column("category_id")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Column("payment_type_id")]
        [ForeignKey("CoursePaymentType")]
        public int PaymentTypeId { get; set; }
        public CoursePaymentType CoursePaymentType { get; set; }

        [Column("level_id")]
        [ForeignKey("Level")]
        public int LevelId { get; set; }
        public Level Level { get; set; }

        [Column("combo_id")]
        [ForeignKey("Combo")]
        public int ComboId { get; set; }
        public Combo Combo { get; set; }

        public int ViewCount { get; set; }
        public bool Active { get; set; }

        public ICollection<Document> Documents { get; set; }
        public ICollection<Video> Videos { get; set; }
        public ICollection<StudentFeedback> StudentFeedbacks { get; set; }
        public ICollection<CourseFeedback> CourseFeedbacks { get; set; }
        public ICollection<CourseBasket> CourseBaskets { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Cart> Carts { get; set; }

    }
}
