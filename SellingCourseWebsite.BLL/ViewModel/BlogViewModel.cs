using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreateDate { get; set; }
        public int ViewCount { get; set; }
        public string Content { get; set; }
        public bool Active { get; set; }
        public int BlogTypeId { get; set; }
        public string BlogTypeName { get; set; }
        public BlogType BlogType { get; set; }
    }
}
