using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gitcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation str1 = new Operation();
            Operation str2 = new Operation();
            Console.WriteLine("请输入要进行操作的第一个字符串：");
            str1.Str = Console.ReadLine();
            Console.WriteLine("请输入要进行操作的第二个字符串：");
            str2.Str = Console.ReadLine();
            Console.WriteLine("请输入要进行的运算的操作：(仅限(+)/(-))");
            string deal = Console.ReadLine();
            switch (deal)
            {
                case "+":
                     Console.WriteLine("运算结果为：" + str1.Addition(str2));
                     break;
                case "-":
                     Console.WriteLine("运算结果为：" + str1.Subtraction(str2));
                     break;
                default:
                     Console.WriteLine("输入的运算符有误！");
                     break;
            }
            Console.ReadKey();
        }
        public class Operation
        {
            private string _str;
            public string Str
            {
                get { return _str; }
                set { _str = value; }
            }
            public string Addition(Operation b)
            {
                string result = this.Str + b.Str;
                return result;
            }
            public string Subtraction(Operation b)
            {
                string result = this.Str.Replace(b.Str,"");

                return result;
            }
        }
    }
}
