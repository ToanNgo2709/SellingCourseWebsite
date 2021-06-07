using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class VideoViewModel
    {
        public int Id { get; set; }
        public string VideoName { get; set; }
        public string YoutubeUrl { get; set; }
        public string PaymentVideoPath { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public DateTime CreateTime { get; set; }
        public bool Active { get; set; }
    }
}
