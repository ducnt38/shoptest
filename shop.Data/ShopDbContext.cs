using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using shop.Model.Model;

namespace shop.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base("ShopEdu") 
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        //khai bao cac bang lien quan
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menu { set; get; }
        public DbSet<MenuGroup> MenuGroup { set; get; }
        public DbSet<Order> Order { set; get; }
        public DbSet<OrderDetail> OrderDetail { set; get; }
        public DbSet<Page> Page { set; get; }
        public DbSet<Post> Post { set; get; }
        public DbSet<PostCategory> PostCategory { set; get; }
        public DbSet<PostTag> PostTag { set; get; }
        public DbSet<Product> Product { set; get; }
        public DbSet<ProductCategory> ProductCategory { set; get; }
        public DbSet<ProductTag> ProductTag { set; get; }
        public DbSet<Slide> Slide { set; get; }
        public DbSet<SupportOnline> SupportOnline { set; get; }
        public DbSet<SystemConfig> SystemConfig { set; get; }
        public DbSet<Tag> Tag { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistic { set; get; }
        protected override void OnModelCreating(DbModelBuilder builder) 
        { 
        
        }
    }
}
