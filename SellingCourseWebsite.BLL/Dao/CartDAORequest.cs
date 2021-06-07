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
    public class CartDAORequest : ICrudRepository<CartViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();
        public int Add(CartViewModel type)
        {
            Cart cart = new Cart()
            {
                Active = type.Active,
                Course = type.Course,
                CourseId = type.CourseId,
                Quantity = type.Quantity,
                TempTotal = type.TempTotal,
                UserInfo = type.UserInfo,
                UserInfoId = type.UserInfoId
            };
            context.Carts.Add(cart);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.Carts.Where(c => c.Id == id).FirstOrDefault();
            context.Carts.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<CartViewModel> GetAll()
        {
            var list = context.Carts
                .Select(c => new CartViewModel
                {
                    Id = c.Id,
                    Active = c.Active,
                    Course = c.Course,
                    CourseId = c.CourseId,
                    Quantity = c.Quantity,
                    TempTotal = c.TempTotal,
                    UserInfo = c.UserInfo,
                    UserInfoId = c.UserInfoId
                })
                .ToList();
            return list;
        }

        public CartViewModel GetById(int id)
        {
            var item = context.Carts
                .Where(c => c.Id == id)
                .Select(c => new CartViewModel
                {
                    Id = c.Id,
                    Active = c.Active,
                    Course = c.Course,
                    CourseId = c.CourseId,
                    Quantity = c.Quantity,
                    TempTotal = c.TempTotal,
                    UserInfo = c.UserInfo,
                    UserInfoId = c.UserInfoId
                })
                .FirstOrDefault();
            return item;
        }

        public List<CartViewModel> Search(string keyword)
        {
            var list = context.Carts
                .Where(c => c.Course.CourseName.ToLower().Contains(keyword.ToLower()))
                .Select(c => new CartViewModel
                {
                    Id = c.Id,
                    Active = c.Active,
                    Course = c.Course,
                    CourseId = c.CourseId,
                    Quantity = c.Quantity,
                    TempTotal = c.TempTotal,
                    UserInfo = c.UserInfo,
                    UserInfoId = c.UserInfoId
                })
                .ToList();
            return list;
        }

        public int Update(CartViewModel type)
        {
            var item = context.Carts.Where(c => c.Id == type.Id).FirstOrDefault();
            item.Active = type.Active;
            item.Course = type.Course;
            item.CourseId = type.CourseId;
            item.Quantity = type.Quantity;
            item.TempTotal = type.TempTotal;
            item.UserInfo = type.UserInfo;
            item.UserInfoId = type.UserInfoId;

            context.SaveChanges();
            return 1;
        }
    }
}
