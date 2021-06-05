using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("Combo")]
    public class Combo
    {
        [Key]
        [Column("id", TypeName = "int")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("sale_price")]
        public decimal SalePrice { get; set; }

        [Column("image_path")]
        public string ImagePath { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        public ICollection<Course> Courses { get; set; }


    }
}
