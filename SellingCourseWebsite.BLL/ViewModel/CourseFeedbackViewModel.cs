using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class CourseFeedbackViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public bool Active { get; set; }

    }
}
