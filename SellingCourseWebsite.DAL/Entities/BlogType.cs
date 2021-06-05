using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("BlogType")]
    public class BlogType
    {
        [Key]
        [Column("id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name", TypeName = "nvarchar")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Column("active", TypeName = "bit")]
        public bool Active { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
