using SellingCourseWebsite.BLL.Repository;
using SellingCourseWebsite.BLL.ViewModel;
using SellingCourseWebsite.DAL;
using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.Dao
{
    public class VideoDAORequest : ICrudRepository<VideoViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(VideoViewModel type)
        {
            Video video = new()
            {
                Active = type.Active,
                VideoName = type.VideoName,
                YoutubeUrl = type.YoutubeUrl,
                PaymentVideoPath = type.PaymentVideoPath,
                CourseId = type.CourseId,
                CreateDate = type.CreateTime,
                Course = type.Course
            };
            context.Videos.Add(video);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.Videos.Where(v => v.Id == id).FirstOrDefault();
            context.Videos.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<VideoViewModel> GetAll()
        {
            var list = context.Videos
                .Select(v => new VideoViewModel { 
                    Id = v.Id,
                    VideoName = v.VideoName,
                    YoutubeUrl = v.YoutubeUrl,
                    PaymentVideoPath = v.PaymentVideoPath,
                    Course = v.Course,
                    CourseId = v.CourseId,
                    Active = v.Active,
                    CreateTime = v.CreateDate
                })
                .ToList();
            return list;
        }

        public VideoViewModel GetById(int id)
        {
            var item = context.Videos
                .Where(v => v.Id == id)
                .Select(v => new VideoViewModel
                {
                    Id = v.Id,
                    VideoName = v.VideoName,
                    YoutubeUrl = v.YoutubeUrl,
                    PaymentVideoPath = v.PaymentVideoPath,
                    Course = v.Course,
                    CourseId = v.CourseId,
                    Active = v.Active,
                    CreateTime = v.CreateDate
                })
                .FirstOrDefault();
            return item;
        }

        public List<VideoViewModel> Search(string keyword)
        {
            var list = context.Videos
                .Where(v => v.VideoName.ToLower().Contains(keyword.ToLower()))
                .Select(v => new VideoViewModel
                {
                    Id = v.Id,
                    VideoName = v.VideoName,
                    YoutubeUrl = v.YoutubeUrl,
                    PaymentVideoPath = v.PaymentVideoPath,
                    Course = v.Course,
                    CourseId = v.CourseId,
                    Active = v.Active,
                    CreateTime = v.CreateDate
                })
                .ToList();
            return list;
        }

        public int Update(VideoViewModel type)
        {
            var item = context.Videos.Where(v => v.Id == type.Id).FirstOrDefault();

            item.Active = type.Active;
            item.VideoName = type.VideoName;
            item.YoutubeUrl = type.YoutubeUrl;
            item.PaymentVideoPath = type.PaymentVideoPath;
            item.CourseId = type.CourseId;
            item.CreateDate = type.CreateTime;
            item.Course = type.Course;

            context.SaveChanges();
            return 1;
        }
    }
}
