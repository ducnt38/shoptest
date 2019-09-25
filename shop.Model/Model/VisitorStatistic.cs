using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Model.Model
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public string VisitorID { set; get; }

        [Required]
        public DateTime VisitedDate { set; get; }

        [Required]
        public string IPAddress { set; get; }
    }
}
