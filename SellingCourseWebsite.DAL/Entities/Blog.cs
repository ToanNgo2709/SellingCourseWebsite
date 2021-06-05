using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        [Column("id", TypeName ="int")]
        public int Id { get; set; }

        [Column("title", TypeName ="nvarchar")]
        public string Title { get; set; }

        [Column("author", TypeName = "author")]
        public string Author { get; set; }

        [Column("create_date", TypeName = "date")]
        public DateTime CreateDate { get; set; }

        [Column("view_count", TypeName = "int")]
        public int ViewCount { get; set; }

        [Column("content", TypeName = "nvarchar")]
        public string Content { get; set; }

        [Column("active", TypeName = "bit")]
        public bool Active { get; set; }

        [Column("blog_type_id")]
        [ForeignKey("Blog")]
        public int BlogTypeId { get; set; }

        public BlogType BlogType { get; set; }
    }
}
