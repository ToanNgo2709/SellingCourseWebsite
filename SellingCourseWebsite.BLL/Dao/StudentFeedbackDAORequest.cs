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
    public class StudentFeedbackDAORequest : ICrudRepository<StudentFeedbackViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(StudentFeedbackViewModel type)
        {
            StudentFeedback studentFeedback = new()
            {
                StudentName = type.StudentName,
                Active = type.Active,
                AvatarImagePath = type.AvatarImagePath,
                Content = type.Content,
                Course = type.Course,
                CourseId = type.CourseId,
                CreateDate = type.CreateDate,
                Email = type.Email,
                WorkStudyAddress = type.WorkStudyAddress
            };
            context.StudentFeedbacks.Add(studentFeedback);
            context.SaveChanges();

            return 1;
        }

        public int Delete(int id)
        {
            var item = context.StudentFeedbacks.Where(c => c.Id == id).FirstOrDefault();
            context.StudentFeedbacks.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<StudentFeedbackViewModel> GetAll()
        {
            var list = context.StudentFeedbacks
                .Select(s => new StudentFeedbackViewModel
                {
                    Id = s.Id,
                    Active = s.Active,
                    AvatarImagePath = s.AvatarImagePath,
                    Content = s.Content,
                    Course = s.Course,
                    CourseId = s.CourseId,
                    CreateDate = s.CreateDate,
                    Email = s.Email,
                    StudentName = s.StudentName,
                    WorkStudyAddress = s.WorkStudyAddress
                })
                .ToList();
            return list;
        }

        public StudentFeedbackViewModel GetById(int id)
        {
            var item = context.StudentFeedbacks
                .Where(s => s.Id == id)
                .Select(s => new StudentFeedbackViewModel
                {
                    Id = s.Id,
                    Active = s.Active,
                    AvatarImagePath = s.AvatarImagePath,
                    Content = s.Content,
                    Course = s.Course,
                    CourseId = s.CourseId,
                    CreateDate = s.CreateDate,
                    Email = s.Email,
                    StudentName = s.StudentName,
                    WorkStudyAddress = s.WorkStudyAddress
                })
                .FirstOrDefault();
            return item;
        }

        public List<StudentFeedbackViewModel> Search(string keyword)
        {
            var list = context.StudentFeedbacks
                .Where(s => s.StudentName.ToLower().Contains(keyword.ToLower()))
                .Select(s => new StudentFeedbackViewModel
                {
                    Id = s.Id,
                    Active = s.Active,
                    AvatarImagePath = s.AvatarImagePath,
                    Content = s.Content,
                    Course = s.Course,
                    CourseId = s.CourseId,
                    CreateDate = s.CreateDate,
                    Email = s.Email,
                    StudentName = s.StudentName,
                    WorkStudyAddress = s.WorkStudyAddress
                })
                .ToList();
            return list;
        }

        public int Update(StudentFeedbackViewModel type)
        {
            var item = context.StudentFeedbacks.Where(c => c.Id ==type.Id).FirstOrDefault();
            item.StudentName = type.StudentName;
            item.Active = type.Active;
            item.AvatarImagePath = type.AvatarImagePath;
            item.Content = type.Content;
            item.Course = type.Course;
            item.CourseId = type.CourseId;
            item.CreateDate = type.CreateDate;
            item.Email = type.Email;
            item.WorkStudyAddress = type.WorkStudyAddress;

            context.SaveChanges();
            return 1;
        }
    }
}
