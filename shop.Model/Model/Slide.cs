using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Model.Model
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        public int SlideID { set; get; }

        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        [MaxLength(256)]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }

        public bool? Status { set; get; }
    }
}
