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
    public class UserTypeDAORequest : ICrudRepository<UserTypeViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(UserTypeViewModel type)
        {
            UserType userType = new()
            {
                Active = type.Active,
                Name = type.Name
            };
            context.UserTypes.Add(userType);
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.UserTypes.Where(u => u.Id == id).FirstOrDefault();
            context.UserTypes.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<UserTypeViewModel> GetAll()
        {
            var list = context.UserTypes
                .Select(u => new UserTypeViewModel
                {
                    Id = u.Id,
                    Active = u.Active,
                    Name = u.Name
                })
                .ToList();
            return list;
        }

        public UserTypeViewModel GetById(int id)
        {
            var item = context.UserTypes
                .Where(u => u.Id == id)
                .Select(u => new UserTypeViewModel
                {
                    Id = u.Id,
                    Active = u.Active,
                    Name = u.Name
                })
                .FirstOrDefault();
            return item;
        }

        public List<UserTypeViewModel> Search(string keyword)
        {
            var list = context.UserTypes
                .Where(u => u.Name.ToLower().Contains(keyword.ToLower()))
                .Select(u => new UserTypeViewModel
                {
                    Id = u.Id,
                    Active = u.Active,
                    Name = u.Name
                })
                .ToList();
            return list;
        }

        public int Update(UserTypeViewModel type)
        {
            var item = context.UserTypes.Where(u => u.Id == type.Id).FirstOrDefault();
            item.Active = type.Active;
            item.Name = type.Name;

            context.SaveChanges();
            return 1;
        }
    }
}
