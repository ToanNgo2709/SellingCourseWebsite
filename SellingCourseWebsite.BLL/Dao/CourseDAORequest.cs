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
    public class CourseDAORequest : ICrudRepository<CourseViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(CourseViewModel type)
        {
            Course newCourse = new Course()
            {
                CourseName = type.CourseName,
                Description = type.Description,
                ImagePath = type.ImagePath,
                Teacher = type.Teacher,
                TeacherId = type.TeacherId,
                Price = type.Price,
                SalePrice = type.SalePrice,
                Category = type.Category,
                CategoryId = type.CategoryId,
                PaymentTypeId = type.PaymentTypeId,
                CoursePaymentType = type.CoursePaymentType,
                Level = type.Level,
                LevelId = type.LevelId,
                Combo = type.Combo,
                ViewCount = type.ViewCount,
                Active = type.Active
            };
            context.Courses.Add(newCourse);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.Courses.Where(c => c.Id == id).FirstOrDefault();
            context.Courses.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<CourseViewModel> GetAll()
        {
            var list = context.Courses.Select(c => new CourseViewModel
            {
                Active = c.Active,
                Category = c.Category,
                CategoryId = c.CategoryId,
                Combo = c.Combo,
                ComboId = c.ComboId,
                CourseName = c.CourseName,
                CoursePaymentType = c.CoursePaymentType,
                Description = c.Description,
                Id = c.Id,
                ImagePath = c.ImagePath,
                Level = c.Level,
                LevelId = c.LevelId,
                PaymentTypeId = c.PaymentTypeId,
                Price = c.Price,
                SalePrice = c.SalePrice,
                Teacher = c.Teacher,
                TeacherId = c.TeacherId,
                ViewCount = c.ViewCount
            }).ToList();
            return list;
        }

        public CourseViewModel GetById(int id)
        {
            var item = context.Courses
                .Where(c => c.Id == id)
                .Select(c => new CourseViewModel
                {
                    Active = c.Active,
                    Category = c.Category,
                    CategoryId = c.CategoryId,
                    Combo = c.Combo,
                    ComboId = c.ComboId,
                    CourseName = c.CourseName,
                    CoursePaymentType = c.CoursePaymentType,
                    Description = c.Description,
                    Id = c.Id,
                    ImagePath = c.ImagePath,
                    Level = c.Level,
                    LevelId = c.LevelId,
                    PaymentTypeId = c.PaymentTypeId,
                    Price = c.Price,
                    SalePrice = c.SalePrice,
                    Teacher = c.Teacher,
                    TeacherId = c.TeacherId,
                    ViewCount = c.ViewCount
                }).FirstOrDefault();
            return item;
        }

        public List<CourseViewModel> Search(string keyword)
        {
            var list = context.Courses
                .Where(c => c.CourseName.ToLower().Contains(keyword.ToLower()))
                .Select(c => new CourseViewModel
                {
                    Active = c.Active,
                    Category = c.Category,
                    CategoryId = c.CategoryId,
                    Combo = c.Combo,
                    ComboId = c.ComboId,
                    CourseName = c.CourseName,
                    CoursePaymentType = c.CoursePaymentType,
                    Description = c.Description,
                    Id = c.Id,
                    ImagePath = c.ImagePath,
                    Level = c.Level,
                    LevelId = c.LevelId,
                    PaymentTypeId = c.PaymentTypeId,
                    Price = c.Price,
                    SalePrice = c.SalePrice,
                    Teacher = c.Teacher,
                    TeacherId = c.TeacherId,
                    ViewCount = c.ViewCount
                }).ToList();
            return list;
        }

        public int Update(CourseViewModel type)
        {
            var item = context.Courses.Where(c => c.Id == type.Id).FirstOrDefault();
            item.CourseName = type.CourseName;
            item.Description = type.Description;
            item.ImagePath = type.ImagePath;
            item.TeacherId = type.TeacherId;
            item.Price = type.Price;
            item.SalePrice = type.SalePrice;
            item.CategoryId = type.CategoryId;
            item.PaymentTypeId = type.PaymentTypeId;
            item.LevelId = type.LevelId;
            item.ComboId = type.ComboId;
            item.ViewCount = type.ViewCount;
            item.Active = type.Active;

            context.SaveChanges();
            return 1;
        }
    }
}
