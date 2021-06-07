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
    public class BlogTypeDAORequest : ICrudRepository<BlogTypeViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(BlogTypeViewModel type)
        {
            BlogType newType = new BlogType()
            {
                Active = type.Active,
                Name = type.Name
            };
            context.BlogTypes.Add(newType);
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.BlogTypes.Where(b => b.Id == id).FirstOrDefault();
            context.BlogTypes.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<BlogTypeViewModel> GetAll()
        {
            var list = context.BlogTypes
                .Select(b => new BlogTypeViewModel
                {
                    Id = b.Id,
                    Active = b.Active,
                    Name = b.Name
                }).ToList();
            return list;

        }

        public BlogTypeViewModel GetById(int id)
        {
            var item = context.BlogTypes
                .Where(b => b.Id == id)
                .Select(b => new BlogTypeViewModel
                {
                    Id = b.Id,
                    Active = b.Active,
                    Name = b.Name
                }).FirstOrDefault();
            return item;
        }

        public List<BlogTypeViewModel> Search(string keyword)
        {
            var list = context.BlogTypes
               .Where(b => b.Name.ToLower().Contains(keyword.ToLower()))
               .Select(b => new BlogTypeViewModel
               {
                   Id = b.Id,
                   Active = b.Active,
                   Name = b.Name
               }).ToList();
            return list;
        }

        public int Update(BlogTypeViewModel type)
        {
            var item = context.BlogTypes.Where(b => b.Id == type.Id)
                .FirstOrDefault();
            item.Name = type.Name;
            item.Active = type.Active;
            context.SaveChanges();
            return 1;
        }
    }
}
