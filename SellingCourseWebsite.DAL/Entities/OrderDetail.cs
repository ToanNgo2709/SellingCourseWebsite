using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("cart_id")]
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public Cart Cart { get; set; }

        [Column("order_id")]
        [ForeignKey("OrderInfo")]
        public int OrderId { get; set; }
        public OrderInfo OrderInfo { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}
