﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"  Eklendi");
        }
    }
}
