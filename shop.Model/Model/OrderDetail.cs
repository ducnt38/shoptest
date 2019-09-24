using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Model.Model
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [ForeignKey("OrderID")]
        public virtual OrderDetail OrderDetails { set; get; }

        [Required]
        public int OrderID { set; get; }

        [Required]
        public int ProductID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }

        public int? Quantity { set; get; }
    }
}
