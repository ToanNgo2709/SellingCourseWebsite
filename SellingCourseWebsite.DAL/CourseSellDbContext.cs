using Microsoft.EntityFrameworkCore;
using SellingCourseWebsite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.DAL
{
    public class CourseSellDbContext : DbContext
    {
        private static CourseSellDbContext _instance;
        private CourseSellDbContext()
        {
            
        }
        
        public static CourseSellDbContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CourseSellDbContext();
            }
            return _instance;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Course_Selling;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseBasket> CourseBaskets { get; set; }
        public DbSet<CourseFeedback> CourseFeedbacks { get; set; }
        public DbSet<CoursePaymentType> CoursePaymentTypes { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderInfo> OrderInfos { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<StudentFeedback> StudentFeedbacks { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
