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
    public class CoursePaymentTypeDAORequest : ICrudRepository<CoursePaymentTypeViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(CoursePaymentTypeViewModel type)
        {
            CoursePaymentType newType = new()
            {
                Name = type.Name,
                CreateDate = type.CreateDate,
                Active = type.Active
            };
            context.CoursePaymentTypes.Add(newType);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.CoursePaymentTypes.Where(c => c.Id == id).FirstOrDefault();
            context.CoursePaymentTypes.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<CoursePaymentTypeViewModel> GetAll()
        {
            var list = context.CoursePaymentTypes
                .Select(c => new CoursePaymentTypeViewModel {
                    Id = c.Id,
                    Name = c.Name,
                    Active = c.Active,
                    CreateDate = c.CreateDate
                })
                .ToList();
            return list;
        }

        public CoursePaymentTypeViewModel GetById(int id)
        {
            var item = context.CoursePaymentTypes
                .Where(c => c.Id == id)
                .Select(c => new CoursePaymentTypeViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Active = c.Active,
                    CreateDate = c.CreateDate
                })
                .FirstOrDefault();
            return item;
        }

        public List<CoursePaymentTypeViewModel> Search(string keyword)
        {
            var list = context.CoursePaymentTypes
                .Where(c => c.Name.ToLower().Contains(keyword.ToLower()))
                .Select(c => new CoursePaymentTypeViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Active = c.Active,
                    CreateDate = c.CreateDate
                })
                .ToList();
            return list;
        }

        public int Update(CoursePaymentTypeViewModel type)
        {
            var item = context.CoursePaymentTypes.Where(c => c.Id == type.Id).FirstOrDefault();
            item.Name = type.Name;
            item.CreateDate = type.CreateDate;
            item.Active = type.Active;
            context.SaveChanges();
            return 1;
        }
    }
}
