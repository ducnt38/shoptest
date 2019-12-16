using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace shop.Data
{
    public class ShopDbContext : DbContent
    {
        public ShopDbContext() : base("ShopEdu") 
        { 
        //this.Configuration
        }
    }
}
