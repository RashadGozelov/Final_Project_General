﻿using Final_Projectt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Projectt.ViewModel
{
    public class HeaderViewModel
    {
        public HeaderViewModel()
        {
            Categories = new List<CategoryViewModel>();
        }
        public string Image { get; set; }

        public List<CategoryViewModel> Categories = null;

        public IEnumerable<Product> Products { get; set; }
    }
}
