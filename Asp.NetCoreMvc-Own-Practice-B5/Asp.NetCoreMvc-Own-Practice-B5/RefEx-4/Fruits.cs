﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefEx_4
{
    public class Fruits : IProduct
    {
        public void PrintMe()
        {
            Console.WriteLine("I am Fruits");
        }
    }
}
