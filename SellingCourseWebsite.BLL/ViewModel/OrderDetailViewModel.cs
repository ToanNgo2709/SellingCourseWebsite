using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class OrderDetailViewModel
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public int OrderId { get; set; }
        public OrderInfo OrderInfo { get; set; }

        public bool Active { get; set; }
    }
}
