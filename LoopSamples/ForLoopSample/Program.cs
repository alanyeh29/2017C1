﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i < 11; i++)
            {
                result = result + i;
            }
            Console.Write("加總結果 :");
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
