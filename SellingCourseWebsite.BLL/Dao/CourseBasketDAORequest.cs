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
    public class CourseBasketDAORequest : ICrudRepository<CourseBasketViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(CourseBasketViewModel type)
        {
            CourseBasket newBasket = new CourseBasket()
            {
                UserInfo = type.UserInfo,
                UserInfoId = type.UserInfoId,
                Course = type.Course,
                Active = type.Active,
                CourseId = type.CourseId
            };
            context.CourseBaskets.Add(newBasket);
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.CourseBaskets
                .Where(c => c.Id == id)
                .FirstOrDefault();
            context.CourseBaskets.Remove(item);
            return 1;

        }

        public List<CourseBasketViewModel> GetAll()
        {
            var list = context.CourseBaskets
                .Select(c => new CourseBasketViewModel
                {
                    Id = c.Id,
                    Active = c.Active,
                    Course = c.Course,
                    CourseId = c.CourseId,
                    UserInfo = c.UserInfo,
                    UserInfoId = c.UserInfoId
                }).ToList();
            return list;
        }

        public CourseBasketViewModel GetById(int id)
        {
            var item = context.CourseBaskets
               .Where(c => c.Id == id)
               .Select(c => new CourseBasketViewModel
               {
                   Id = c.Id,
                   Active = c.Active,
                   Course = c.Course,
                   CourseId = c.CourseId,
                   UserInfo = c.UserInfo,
                   UserInfoId = c.UserInfoId
               }).FirstOrDefault();
            return item;
        }

        public List<CourseBasketViewModel> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public int Update(CourseBasketViewModel type)
        {
            var item = context.CourseBaskets
                .Where(c => c.Id == type.Id)
                .FirstOrDefault();
            item.Id = type.Id;
            item.Active = type.Active;
            item.Course = type.Course;
            item.CourseId = type.CourseId;
            item.UserInfo = type.UserInfo;
            item.UserInfoId = type.UserInfoId;
            context.SaveChanges();
            return 1;
        }
    }
}
