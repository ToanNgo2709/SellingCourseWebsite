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
    public class BlogDAORequest : ICrudRepository<BlogViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(BlogViewModel type)
        {
            Blog newBlog = new Blog() { 
                Active = type.Active,
                Author = type.Author,
                BlogType = type.BlogType,
                BlogTypeId = type.BlogTypeId,
                Content = type.Content,
                CreateDate = type.CreateDate,
                Title = type.Title,
                ViewCount = type.ViewCount
            };
            context.Blogs.Add(newBlog);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.Blogs.Where(b => b.Id == id).FirstOrDefault();
            context.Blogs.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<BlogViewModel> GetAll()
        {
            var list = context.Blogs.Select(b => new BlogViewModel
            {
                Active = b.Active,
                Author = b.Author,
                BlogType = b.BlogType,
                BlogTypeId = b.BlogTypeId,
                BlogTypeName = b.BlogType.Name,
                Content = b.Content,
                CreateDate = b.CreateDate,
                Id = b.Id,
                Title = b.Title,
                ViewCount = b.ViewCount
            }).ToList();
            return list;
        }

        public BlogViewModel GetById(int id)
        {
            var item = context.Blogs.Where(b => b.Id == id)
                .Select(b => new BlogViewModel
            {
                Active = b.Active,
                Author = b.Author,
                BlogType = b.BlogType,
                BlogTypeId = b.BlogTypeId,
                BlogTypeName = b.BlogType.Name,
                Content = b.Content,
                CreateDate = b.CreateDate,
                Id = b.Id,
                Title = b.Title,
                ViewCount = b.ViewCount
            }).FirstOrDefault();
            return item;
        }

        public List<BlogViewModel> Search(string keyword)
        {
            var list = context.Blogs.Where(b => b.Author.ToLower().Contains(keyword.ToLower()))
                .Select(b => new BlogViewModel
                {
                    Active = b.Active,
                    Author = b.Author,
                    BlogType = b.BlogType,
                    BlogTypeId = b.BlogTypeId,
                    BlogTypeName = b.BlogType.Name,
                    Content = b.Content,
                    CreateDate = b.CreateDate,
                    Id = b.Id,
                    Title = b.Title,
                    ViewCount = b.ViewCount
                }).ToList();
            return list;
        }

        public int Update(BlogViewModel type)
        {
            var item = context.Blogs.Where(b => b.Id == type.Id).FirstOrDefault();
            item.Id = type.Id;
            item.Content = type.Content;
            item.Active = type.Active;
            item.Author = type.Author;
            item.Title = type.Title;
            item.ViewCount = type.ViewCount;
            item.BlogType = type.BlogType;
            item.BlogTypeId = type.BlogTypeId;

            context.SaveChanges();
            return 1;
        }
    }
}
