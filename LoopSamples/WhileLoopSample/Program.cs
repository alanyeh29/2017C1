using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i = 1;
            while (i < 11)
            {
                result = result + i;
                i = i + 1;
            }
            Console.Write("加總結果 :");
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
