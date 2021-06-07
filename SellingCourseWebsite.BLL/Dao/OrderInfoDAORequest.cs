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
    public class OrderInfoDAORequest : ICrudRepository<OrderInfoViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(OrderInfoViewModel type)
        {
            OrderInfo newOrder = new()
            {
                Active = type.Active,
                CreateDate = type.CreateDate,
                PaymentMethod = type.PaymentMethod,
                PaymentMethodId = type.PaymentMethodId,
                Total = type.Total
            };
            context.OrderInfos.Add(newOrder);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.OrderInfos.Where(o => o.Id == id).FirstOrDefault();
            context.OrderInfos.Remove(item);
            context.SaveChanges();
            return 1;
        }

        public List<OrderInfoViewModel> GetAll()
        {
            var list = context.OrderInfos
                .Select(o => new OrderInfoViewModel { 
                    Id = o.Id,
                    Active = o.Active,
                    CreateDate = o.CreateDate,
                    PaymentMethod = o.PaymentMethod,
                    PaymentMethodId = o.PaymentMethodId,
                    Total = o.Total
                })
                .ToList();
            return list;
        }

        public OrderInfoViewModel GetById(int id)
        {
            var item = context.OrderInfos
                .Where(o => o.Id == id)
                .Select(o => new OrderInfoViewModel
                {
                    Id = o.Id,
                    Active = o.Active,
                    CreateDate = o.CreateDate,
                    PaymentMethod = o.PaymentMethod,
                    PaymentMethodId = o.PaymentMethodId,
                    Total = o.Total
                })
                .FirstOrDefault();
            return item;
        }

        public List<OrderInfoViewModel> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public int Update(OrderInfoViewModel type)
        {
            var item = context.OrderInfos.Where(o => o.Id == type.Id).FirstOrDefault();
            item.Active = type.Active;
            item.CreateDate = type.CreateDate;
            item.PaymentMethod = type.PaymentMethod;
            item.PaymentMethodId = type.PaymentMethodId;
            item.Total = type.Total;
            context.SaveChanges();
            return 1;
        }
    }
}
