using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Model.Model
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderID { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }

        [Required]
        public string CustomerName { set; get; }

        public string CustomerAddress { set; get; }

        public string CustomerEmail { set; get; }

        [Required]
        public string CustomerMobile { set; get; }

        public string CustomerMessage { set; get; }

        public string CreateDate { set; get; }

        public string CreateBy { set; get; }

        public string PaymentMethod { set; get; }

        public string PaymentStatus { set; get; }

        [Required]
        public bool Status { set; get; }

    }
}
