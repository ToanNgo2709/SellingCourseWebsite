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
    public class LevelDAORequest : ICrudRepository<LevelViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(LevelViewModel type)
        {
            Level newLevel = new()
            {
                Name = type.Name,
                Active = type.Active,

            };
            context.Levels.Add(newLevel);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.Levels.Where(c => c.Id == id).FirstOrDefault();
            context.Levels.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<LevelViewModel> GetAll()
        {
            var list = context.Levels
                .Select(l => new LevelViewModel
                {
                    Id = l.Id,
                    Active = l.Active,
                    Name = l.Name
                })
                .ToList();
            return list;
        }

        public LevelViewModel GetById(int id)
        {
            var item = context.Levels
                .Where(l => l.Id == id)
                .Select(l => new LevelViewModel
                {
                    Id = l.Id,
                    Active = l.Active,
                    Name = l.Name
                })
                .FirstOrDefault();
            return item;
        }

        public List<LevelViewModel> Search(string keyword)
        {
            var list = context.Levels
                .Where(l => l.Name.ToLower().Contains(keyword.ToLower()))
                .Select(l => new LevelViewModel
                {
                    Id = l.Id,
                    Active = l.Active,
                    Name = l.Name
                })
                .ToList();
            return list;
        }

        public int Update(LevelViewModel type)
        {
            var item = context.Levels.Where(c => c.Id == type.Id).FirstOrDefault();
            item.Name = type.Name;
            item.Active = type.Active;
            context.SaveChanges();
            return 1;
            
        }
    }
}
