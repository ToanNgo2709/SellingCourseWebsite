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
    public class OrderDetailDAORequest : ICrudRepository<OrderDetailViewModel, int>
    {
        CourseSellDbContext context = CourseSellDbContext.GetInstance();

        public int Add(OrderDetailViewModel type)
        {
            OrderDetail newDetail = new OrderDetail()
            {
                Active = type.Active,
                Cart = type.Cart,
                CartId = type.CartId,
                OrderId = type.OrderId,
                OrderInfo = type.OrderInfo
            };
            context.OrderDetails.Add(newDetail);
            context.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var item = context.OrderDetails.Where(c => c.Id == id).FirstOrDefault();
            context.OrderDetails.Remove(item);
            return 1;
        }

        public List<OrderDetailViewModel> GetAll()
        {
            var list = context.OrderDetails
                .Select(c => new OrderDetailViewModel {
                    Id = c.Id,
                    Active = c.Active,
                    Cart = c.Cart,
                    CartId = c.CartId,
                    OrderId = c.OrderId,
                    OrderInfo = c.OrderInfo
                })
                .ToList();
            return list;
        }

        public OrderDetailViewModel GetById(int id)
        {
            var item = context.OrderDetails
                .Where(c => c.Id == id)
                .Select(c => new OrderDetailViewModel
                {
                    Id = c.Id,
                    Active = c.Active,
                    Cart = c.Cart,
                    CartId = c.CartId,
                    OrderId = c.OrderId,
                    OrderInfo = c.OrderInfo
                })
                .FirstOrDefault();
            return item;
        }

        public List<OrderDetailViewModel> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public int Update(OrderDetailViewModel type)
        {
            var item = context.OrderDetails.Where(c => c.Id == type.Id).FirstOrDefault();
            type.Active = type.Active;
            type.Cart = type.Cart;
            type.CartId = type.CartId;
            type.OrderId = type.OrderId;
            type.OrderInfo = type.OrderInfo;
            context.SaveChanges();

            return 1;
        }
    }
}
