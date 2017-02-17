using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int condition = 10;
            int value;
            Console.WriteLine("請輸入一個數字 :");
            string input = Console.ReadLine();
            value = int.Parse(input);//把input字串解析(parse)成 int
            if (value > condition)
            {
                Console.WriteLine("輸入的值大於 10");
            }
            else
            {
                if (value < condition)
                {
                    Console.WriteLine("輸入的值小於 10");
                }
                else
                {
                    Console.WriteLine("輸入的值等於 10");
                }
            }
            Console.ReadLine();
        }
    }
}

