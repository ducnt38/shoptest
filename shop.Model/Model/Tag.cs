using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Model.Model
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public string TagID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        public string Type { set; get; }

        public virtual IEnumerable<ProductTag> ProductTag { set; get; }
        public virtual IEnumerable<PostTag> PostTag { set; get; }
    }
}
