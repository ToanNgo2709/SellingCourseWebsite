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
    public class TeacherDAORequest : ICrudRepository<TeacherViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(TeacherViewModel type)
        {
            Teacher teacher = new()
            {
                Active = type.Active,
                CurrentPosition = type.CurrentPosition,
                Job = type.Job,
                Skill = type.Skill,
                TeachingExperience = type.TeachingExperience,
                UserInfo = type.UserInfo,
                UserInfoId = type.UserInfoId
            };
            context.Teachers.Add(teacher);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.Teachers.Where(t => t.Id == id).FirstOrDefault();
            context.Teachers.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<TeacherViewModel> GetAll()
        {
            var list = context.Teachers
                .Select(t => new TeacherViewModel
                {
                    Active = t.Active,
                    CurrentPosition = t.CurrentPosition,
                    Id = t.Id,
                    Job = t.Job,
                    Skill = t.Skill,
                    TeachingExperience = t.TeachingExperience,
                    UserInfo = t.UserInfo,
                    UserInfoId = t.UserInfoId
                })
                .ToList();
            return list;
        }

        public TeacherViewModel GetById(int id)
        {
            var item = context.Teachers
                .Where(t => t.Id == id)
                .Select(t => new TeacherViewModel
                {
                    Active = t.Active,
                    CurrentPosition = t.CurrentPosition,
                    Id = t.Id,
                    Job = t.Job,
                    Skill = t.Skill,
                    TeachingExperience = t.TeachingExperience,
                    UserInfo = t.UserInfo,
                    UserInfoId = t.UserInfoId
                })
                .FirstOrDefault();
            return item;
        }

        public List<TeacherViewModel> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public int Update(TeacherViewModel type)
        {
            var item = context.Teachers.Where(t => t.Id == type.Id).FirstOrDefault();
            item.Active = type.Active;
            item.CurrentPosition = type.CurrentPosition;
            item.Job = type.Job;
            item.Skill = type.Skill;
            item.TeachingExperience = type.TeachingExperience;
            item.UserInfo = type.UserInfo;
            item.UserInfoId = type.UserInfoId;
            context.SaveChanges();
            return 1;
        }
    }
}
