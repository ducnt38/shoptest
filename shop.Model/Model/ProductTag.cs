using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Model.Model
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Required]
        public int ProductID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [Required]
        public string TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag{set;get;}
    }
}
