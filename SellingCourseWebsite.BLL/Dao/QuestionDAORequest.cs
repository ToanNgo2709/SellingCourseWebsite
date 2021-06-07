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
    public class QuestionDAORequest : ICrudRepository<QuestionViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(QuestionViewModel type)
        {
            Question newQuestion = new()
            {
                Message = type.Message,
                Active = type.Active,
                Course = type.Course,
                CourseId = type.CourseId,
                CreateDate = type.CreateTime,
                ReplyUserId = type.ReplyUserId,
                UserInfo = type.UserInfo
            };
            context.Questions.Add(newQuestion);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.Questions.Where(q => q.Id == id).FirstOrDefault();
            context.Questions.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<QuestionViewModel> GetAll()
        {
            var list = context.Questions
                .Select(q => new QuestionViewModel() { 
                    Id = q.Id,
                    Active = q.Active,
                    Course = q.Course,
                    CourseId = q.CourseId,
                    CreateTime = q.CreateDate,
                    Message = q.Message,
                    ReplyUserId = q.ReplyUserId,
                    UserInfo = q.UserInfo
                })
                .ToList();
            return list;
        }

        public QuestionViewModel GetById(int id)
        {
            var item = context.Questions
                .Where(q => q.Id == id)
                .Select(q => new QuestionViewModel()
                {
                    Id = q.Id,
                    Active = q.Active,
                    Course = q.Course,
                    CourseId = q.CourseId,
                    CreateTime = q.CreateDate,
                    Message = q.Message,
                    ReplyUserId = q.ReplyUserId,
                    UserInfo = q.UserInfo
                })
                .FirstOrDefault();
            return item;
        }

        public List<QuestionViewModel> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public int Update(QuestionViewModel type)
        {
            var item = context.Questions.Where(q => q.Id == type.Id).FirstOrDefault();
            item.Message = type.Message;
            item.Active = type.Active;
            item.Course = type.Course;
            item.CourseId = type.CourseId;
            item.CreateDate = type.CreateTime;
            item.ReplyUserId = type.ReplyUserId;
            item.UserInfo = type.UserInfo;

            context.SaveChanges();
            return 1;
        }
    }
}
