﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Model.Model
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        public int GroupID { set; get; }

        [Required]
        public string Name { set; get; }

        public virtual IEnumerable<Menu> Menus { set; get; }
    }
}