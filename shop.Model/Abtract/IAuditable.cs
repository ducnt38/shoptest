using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Model.Abtract
{
    public interface IAuditable
    {
        DateTime CreateDate { set; get; }
        String CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
        bool Status { set; get; }
        string MetaKeyWord { set; get; }
        string MetaDescription { set; get; }
    }
}
