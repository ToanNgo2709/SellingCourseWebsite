using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public string Job { get; set; }
        public string CurrentPosition { get; set; }
        public string Skill { get; set; }
        public string TeachingExperience { get; set; }
        public int UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }

        public bool Active { get; set; }
    }
}
