﻿using System.Collections.Generic;

namespace Products.Domain.Entities
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}