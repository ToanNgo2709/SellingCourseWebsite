using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class CoursePaymentTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }

    }
}
