using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using shop.Model.Abtract;

namespace shop.Model.Model
{
    [Table("Products")]
    public class Product : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        public string Alias { set; get; }

        [Required]
        public int CateID { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public XElement MoreImages { set; get; }

        [Required]
        public decimal Price { set; get; }

        public decimal PromotionPrice { set; get; }

        public int? Waranty { set; get; }

        public string Description { set; get; }

        public string Content { set; get; }

        public bool HomeFlag { set; get; }

        public bool HotFlag { set; get; }

        public int? ViewCount { set; get; }

        [ForeignKey("CateID")]
        public virtual ProductCategory ProductCategory { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }
    }
}
