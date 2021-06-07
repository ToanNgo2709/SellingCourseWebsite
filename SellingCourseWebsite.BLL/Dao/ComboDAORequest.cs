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
    public class ComboDAORequest : ICrudRepository<ComboViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(ComboViewModel type)
        {
            Combo newCombo = new Combo() {
                Active = type.Active,
                CreateDate = type.CreateDate,
                ImagePath = type.ImagePath,
                Name = type.Name,
                Price = type.Price,
                SalePrice = type.SalePrice
            };
            context.Combos.Add(newCombo);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.Combos.Where(c => c.Id == id).FirstOrDefault();
            context.Combos.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<ComboViewModel> GetAll()
        {
            var list = context.Combos
                .Select(c => new ComboViewModel { 
                    Id = c.Id,
                    Active = c.Active,
                    CreateDate = c.CreateDate,
                    ImagePath = c.ImagePath,
                    Name = c.Name,
                    Price = c.Price,
                    SalePrice = c.SalePrice
                })
                .ToList();
            return list;
        }

        public ComboViewModel GetById(int id)
        {
            var item = context.Combos
                .Where(c => c.Id == id)
                .Select(c => new ComboViewModel
                {
                    Id = c.Id,
                    Active = c.Active,
                    CreateDate = c.CreateDate,
                    ImagePath = c.ImagePath,
                    Name = c.Name,
                    Price = c.Price,
                    SalePrice = c.SalePrice
                })
                .FirstOrDefault();
            return item;
        }

        public List<ComboViewModel> Search(string keyword)
        {
            var list = context.Combos
                .Where(c => c.Name.ToLower().Contains(keyword.ToLower()))
               .Select(c => new ComboViewModel
               {
                   Id = c.Id,
                   Active = c.Active,
                   CreateDate = c.CreateDate,
                   ImagePath = c.ImagePath,
                   Name = c.Name,
                   Price = c.Price,
                   SalePrice = c.SalePrice
               })
               .ToList();
            return list;
        }

        public int Update(ComboViewModel type)
        {
            var item = context.Combos.Where(c => c.Id == type.Id).FirstOrDefault();
            item.Active = type.Active;
            item.CreateDate = type.CreateDate;
            item.ImagePath = type.ImagePath;
            item.Name = type.Name;
            item.Price = type.Price;
            item.SalePrice = type.SalePrice;
            context.SaveChanges();

            return 1;
        }   
    }
}
