﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class CategoryDTO
    {
        public int? ParentCategoryId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsFeatured { get; set; }
        public bool IsDeleted { get; set; }
        
    }
}
