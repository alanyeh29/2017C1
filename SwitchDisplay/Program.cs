using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;//宣告一個整數型態的變數為value
            Console.WriteLine("請輸入一個數字 :");//印出請輸入一個數字且換行
            string input = Console.ReadLine();//宣告一個字串型態變數為input且得到使用者輸入之字串
            value = int.Parse(input);//將字串input轉為int型態且存至變數value
            string result = GetResult(value);//value引數
            Console.WriteLine(result);
            Console.ReadLine();

        }
        private static string GetResult(int i)//命名原則須採用pascal(首字大寫)
        {
           
            switch (i)
            {
                case 1:
                    return "數字是 1";
                case 2:
                    return "數字是 2";
                default:
                    return "數字不在條件內";
            }
        }
    }
}

