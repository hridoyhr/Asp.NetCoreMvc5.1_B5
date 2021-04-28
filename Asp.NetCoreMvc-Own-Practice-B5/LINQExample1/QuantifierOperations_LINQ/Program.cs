﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace QuantifierOperations_LINQ
{
    class Program
    {
        static List<Market> markets = new List<Market>
        {
            new Market { Name = "Emily", Items = new string[]{ "kiwi", "cherry", "banana"} },
            new Market { Name = "Kim's", Items = new string[]{ "mango", "melon", "olive"} },
            new Market { Name = "Hridoy", Items = new string[]{ "kiwi", "apple", "orange"} }
        };
        static void Main(string[] args)
        {
            //Determine which market have all fruits names length equal = 5
            #region All(method)
            //var names = from market in markets
            //            where market.Items.All(item => item.Length == 5)
            //            select market.Name;

            //foreach(string name in names)
            //    Console.WriteLine(name);
            #endregion

            #region Any Method
            //var names = from market in markets
            //           where market.Items.Any(item => item.StartsWith("o"))
            //           select market.Name;

            //foreach(var name in names)
            //    Console.WriteLine(name);
            #endregion

            #region Contains Method
            var names = from market in markets
                        where market.Items.Contains("kiwi")
                        select market.Name;

            foreach(var name in names)
                Console.WriteLine(name);
            #endregion
        }
    }
}