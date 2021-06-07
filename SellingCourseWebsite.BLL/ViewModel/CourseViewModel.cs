using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int PaymentTypeId { get; set; }
        public CoursePaymentType CoursePaymentType { get; set; }

        public int LevelId { get; set; }
        public Level Level { get; set; }

        public int ComboId { get; set; }
        public Combo Combo { get; set; }

        public int ViewCount { get; set; }
        public bool Active { get; set; }
    }
}
