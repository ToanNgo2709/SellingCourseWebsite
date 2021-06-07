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
    public class PaymentMethodDAORequest : ICrudRepository<PaymentMethodViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(PaymentMethodViewModel type)
        {
            PaymentMethod paymentMethod = new()
            {
                Name = type.Name,
                Active = type.Active
            };
            context.PaymentMethods.Add(paymentMethod);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.PaymentMethods.Where(p => p.Id == id).FirstOrDefault();
            context.PaymentMethods.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<PaymentMethodViewModel> GetAll()
        {
            var list = context.PaymentMethods
                .Select(p => new PaymentMethodViewModel
                {
                    Id = p.Id,
                    Active = p.Active,
                    Name = p.Name
                })
                .ToList();
            return list;
        }

        public PaymentMethodViewModel GetById(int id)
        {
            var item = context.PaymentMethods
                .Where(p => p.Id == id)
                .Select(p => new PaymentMethodViewModel
                {
                    Id = p.Id,
                    Active = p.Active,
                    Name = p.Name
                })
                .FirstOrDefault();
            return item;
        }

        public List<PaymentMethodViewModel> Search(string keyword)
        {
            var list = context.PaymentMethods
                 .Where(p => p.Name.ToLower().Contains(keyword.ToLower()))
                 .Select(p => new PaymentMethodViewModel
                 {
                     Id = p.Id,
                     Active = p.Active,
                     Name = p.Name
                 })
                 .ToList();
            return list;
        }

        public int Update(PaymentMethodViewModel type)
        {
            var item = context.PaymentMethods.Where(p => p.Id == type.Id).FirstOrDefault();
            item.Name = type.Name;
            item.Active = type.Active;
            context.SaveChanges();
            return 1;
        }
    }
}
