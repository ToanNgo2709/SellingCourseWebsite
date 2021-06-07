using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class StudentFeedbackViewModel
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string AvatarImagePath { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string WorkStudyAddress { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    }
}
