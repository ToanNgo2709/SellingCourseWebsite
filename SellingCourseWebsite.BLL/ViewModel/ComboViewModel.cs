using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.ViewModel
{
    public class ComboViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public string ImagePath { get; set; }
        public bool Active { get; set; }
    }
}
