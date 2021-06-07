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
    public class UserInfoDAORequest : ICrudRepository<UserInfoViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(UserInfoViewModel type)
        {
            UserInfo newUser = new()
            {
                Active = type.Active,
                Address = type.Address,
                AvatarImgPath = type.AvatarImgPath,
                Dob = type.Dob,
                Email = type.Email,
                FullName = type.FullName,
                HashPassword = type.HashPassword,
                Phone = type.Phone,
                Username = type.Username,
                UserType = type.UserType,
                UserTypeId = type.UserTypeId,             
            };
            context.UserInfos.Add(newUser);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.UserInfos.Where(u => u.Id == id).FirstOrDefault();
            context.UserInfos.Remove(item);
            context.SaveChanges();
            return 1;
            
        }

        public List<UserInfoViewModel> GetAll()
        {
            var list = context.UserInfos
                .Select(u => new UserInfoViewModel { 
                    Id = u.Id,
                    Username = u.Username,
                    HashPassword = u.HashPassword,
                    FullName = u.FullName,
                    Dob = u.Dob,
                    Email = u.Email,
                    Phone = u.Phone,
                    Address = u.Address,
                    UserType = u.UserType,
                    UserTypeId = u.UserTypeId,
                    Active = u.Active,
                    AvatarImgPath = u.AvatarImgPath
                })
                .ToList();
            return list;
        }

        public UserInfoViewModel GetById(int id)
        {
            var item = context.UserInfos
                .Where(u => u.Id == id)
                .Select(u => new UserInfoViewModel
                {
                    Id = u.Id,
                    Username = u.Username,
                    HashPassword = u.HashPassword,
                    FullName = u.FullName,
                    Dob = u.Dob,
                    Email = u.Email,
                    Phone = u.Phone,
                    Address = u.Address,
                    UserType = u.UserType,
                    UserTypeId = u.UserTypeId,
                    Active = u.Active,
                    AvatarImgPath = u.AvatarImgPath
                })
                .FirstOrDefault();
            return item;
        }

        public List<UserInfoViewModel> Search(string keyword)
        {
            var list = context.UserInfos
                .Where(u => u.Username.ToLower().Contains(keyword.ToLower()))
                .Select(u => new UserInfoViewModel
                {
                    Id = u.Id,
                    Username = u.Username,
                    HashPassword = u.HashPassword,
                    FullName = u.FullName,
                    Dob = u.Dob,
                    Email = u.Email,
                    Phone = u.Phone,
                    Address = u.Address,
                    UserType = u.UserType,
                    UserTypeId = u.UserTypeId,
                    Active = u.Active,
                    AvatarImgPath = u.AvatarImgPath
                })
                .ToList();
            return list;
        }

        public int Update(UserInfoViewModel type)
        {
            var item = context.UserInfos.Where(u => u.Id == type.Id).FirstOrDefault();
            item.Active = type.Active;
            item.Address = type.Address;
            item.AvatarImgPath = type.AvatarImgPath;
            item.Dob = type.Dob;
            item.Email = type.Email;
            item.FullName = type.FullName;
            item.HashPassword = type.HashPassword;
            item.Phone = type.Phone;
            item.Username = type.Username;
            item.UserType = type.UserType;
            item.UserTypeId = type.UserTypeId;

            context.SaveChanges();
            return 1;
        }
    }
}
