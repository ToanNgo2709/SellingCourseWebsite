using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("OrderInfo")]
    public class OrderInfo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("payment_method_id")]
        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
