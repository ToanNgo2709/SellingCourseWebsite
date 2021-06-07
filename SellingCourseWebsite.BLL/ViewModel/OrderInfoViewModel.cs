using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class OrderInfoViewModel
    {
        public int Id { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public DateTime CreateDate { get; set; }
        public decimal Total { get; set; }
        public bool Active { get; set; }
    }
}
