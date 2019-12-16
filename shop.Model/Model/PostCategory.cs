using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.Model.Abtract;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace shop.Model.Model
{
    [Table("PostCategories")]
    public class PostCategory : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostCateID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Column(TypeName="varchar")]
        [Required]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? ParenID { set; get; }

        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string? Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Post> Post { set; get; }
    }
}
