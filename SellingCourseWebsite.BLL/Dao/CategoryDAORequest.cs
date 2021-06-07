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
    public class CategoryDAORequest : ICrudRepository<CategoryViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(CategoryViewModel type)
        {
            Category newCategory = new Category() { 
                Name = type.Name,
                Active = type.Active,
                CreateDate = type.CreateDate
            };
            context.Categories.Add(newCategory);
            context.SaveChanges();

            return 1;

        }

        public int Delete(int id)
        {
            var item = context.Categories.Where(c => c.Id == id).FirstOrDefault();
            context.Categories.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<CategoryViewModel> GetAll()
        {
            var list = context.Categories
                .Select(c => new CategoryViewModel { 
                    Id = c.Id,
                    Name = c.Name,
                    Active = c.Active,
                    CreateDate = c.CreateDate
                })
                .ToList();
            return list;
        }

        public CategoryViewModel GetById(int id)
        {
            var item = context.Categories
                .Where(c => c.Id == id)
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Active = c.Active,
                    CreateDate = c.CreateDate
                })
                .FirstOrDefault();
            return item;
        }

        public List<CategoryViewModel> Search(string keyword)
        {
            var list = context.Categories
                .Where(c => c.Name.ToLower().Contains(keyword.ToLower()))
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Active = c.Active,
                    CreateDate = c.CreateDate
                })
                .ToList();
            return list;
        }

        public int Update(CategoryViewModel type)
        {
            var item = context.Categories.Where(c => c.Id == type.Id).FirstOrDefault();
            item.Name = type.Name;
            item.Active = type.Active;
            item.CreateDate = type.CreateDate;

            context.SaveChanges();
            return 1;
        }
    }
}
