using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class UserInfoViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string HashPassword { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public UserType UserType { get; set; }
        public string AvatarImgPath { get; set; }
        public bool Active { get; set; }
    }
}
