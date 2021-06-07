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
    public class DocumentDAORequest : ICrudRepository<DocumentViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(DocumentViewModel type)
        {
            Document newDoc = new()
            {
                Name = type.Name,
                DocumentUrl = type.DocumentUrl,
                CreateDate = type.CreateDate,
                Active = type.Active,
                Course = type.Course,
                CourseId = type.CourseId
            };
            context.Documents.Add(newDoc);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.Documents.Where(c => c.Id == id).FirstOrDefault();
            context.Documents.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<DocumentViewModel> GetAll()
        {
            var list = context.Documents
                .Select(c => new DocumentViewModel { 
                    Active = c.Active,
                    Course = c.Course,
                    CourseId = c.CourseId,
                    CreateDate = c.CreateDate,
                    DocumentUrl = c.DocumentUrl,
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();
            return list;
        }

        public DocumentViewModel GetById(int id)
        {
            var item = context.Documents
                .Where(c => c.Id == id)
                .Select(c => new DocumentViewModel
                {
                    Active = c.Active,
                    Course = c.Course,
                    CourseId = c.CourseId,
                    CreateDate = c.CreateDate,
                    DocumentUrl = c.DocumentUrl,
                    Id = c.Id,
                    Name = c.Name
                })
                .FirstOrDefault();
            return item;
        }

        public List<DocumentViewModel> Search(string keyword)
        {
            var list = context.Documents
                .Where(c => c.Name.ToLower().Contains(keyword.ToLower()))
                .Select(c => new DocumentViewModel
                {
                    Active = c.Active,
                    Course = c.Course,
                    CourseId = c.CourseId,
                    CreateDate = c.CreateDate,
                    DocumentUrl = c.DocumentUrl,
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();
            return list;
        }

        public int Update(DocumentViewModel type)
        {
            var item = context.Documents.Where(c => c.Id == type.Id).FirstOrDefault();
            item.Name = type.Name;
            item.DocumentUrl = type.DocumentUrl;
            item.CreateDate = type.CreateDate;
            item.Active = type.Active;
            item.Course = type.Course;
            item.CourseId = type.CourseId;
            context.SaveChanges();
            return 1;
        }
    }
}
