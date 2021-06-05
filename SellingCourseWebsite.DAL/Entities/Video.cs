using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL.Entities
{
    [Table("CourseVideo")]
    public class Video
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("video_name")]
        public string VideoName { get; set; }

        [Column("youtube_url")]
        public string YoutubeUrl { get; set; }

        [Column("payment_video_path")]
        public string PaymentVideoPath { get; set; }

        [Column("course_id")]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}
