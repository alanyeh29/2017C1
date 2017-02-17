using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// </summary>
namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">這是一個參數</param>
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("請輸入文字:");
            input = Console.ReadLine();
            Console.Write("你輸入的文字為:");
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
