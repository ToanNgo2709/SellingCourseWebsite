using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int ReplyUserId { get; set; }
        public UserInfo UserInfo { get; set; }
        public string Message { get; set; }
        public DateTime CreateTime { get; set; }
        public bool Active { get; set; }

    }
}
