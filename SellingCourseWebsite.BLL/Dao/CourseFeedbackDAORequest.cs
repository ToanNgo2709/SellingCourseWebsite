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
    public class CourseFeedbackDAORequest : ICrudRepository<CourseFeedbackViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(CourseFeedbackViewModel type)
        {
            CourseFeedback newFeedback = new()
            {
                CreateDate = type.CreateDate,
                Active = type.Active,
                Content = type.Content,
                Course = type.Course,
                CourseId = type.CourseId
            };
            context.CourseFeedbacks.Add(newFeedback);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.CourseFeedbacks.Where(c => c.Id == id).FirstOrDefault();
            context.CourseFeedbacks.Remove(item);
            return 1;
        }

        public List<CourseFeedbackViewModel> GetAll()
        {
            var list = context.CourseFeedbacks
                .Select(c => new CourseFeedbackViewModel { 
                    Active = c.Active,
                    Content = c.Content,
                    Course = c.Course,
                    CourseId = c.CourseId,
                    CreateDate = c.CreateDate,
                    Id = c.Id
                })
                .ToList();
            return list;
        }

        public CourseFeedbackViewModel GetById(int id)
        {
            var item = context.CourseFeedbacks
                .Where(c => c.Id == id)
                .Select(c => new CourseFeedbackViewModel
                {
                    Active = c.Active,
                    Content = c.Content,
                    Course = c.Course,
                    CourseId = c.CourseId,
                    CreateDate = c.CreateDate,
                    Id = c.Id
                })
                .FirstOrDefault();
            return item;
        }

        public List<CourseFeedbackViewModel> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public int Update(CourseFeedbackViewModel type)
        {
            var item = context.CourseFeedbacks.Where(c => c.Id == type.Id).FirstOrDefault();
            item.Active = type.Active;
            item.Content = type.Content;
            item.Course = type.Course;
            item.CourseId = type.CourseId;
            item.CreateDate = type.CreateDate;

            context.SaveChanges();
            return 1;
        }   
    }
}
