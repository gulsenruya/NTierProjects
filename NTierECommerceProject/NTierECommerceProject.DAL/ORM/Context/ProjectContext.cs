using NTierECommerceProject.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerceProject.DAL.ORM.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server=.;database=NTierECommerceDB;uid=sa;pwd=123";
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CategorySubCategory> CategorySubCategories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Many To Many
            modelBuilder.Entity<CategorySubCategory>().HasKey(x => new { x.CategoryId, x.SubCategoryId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
