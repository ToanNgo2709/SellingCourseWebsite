using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class CourseBasketViewModel
    {
        public int Id { get; set; }
        public int UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public bool Active { get; set; }
    }
}
