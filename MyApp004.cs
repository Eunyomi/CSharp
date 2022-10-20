using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 A를 입력하세요 : ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            int n1 = Int32.Parse(input);

            Console.Write("숫자 B를 입력하세요 : ");
            string input2 = Console.ReadLine();
            Console.WriteLine(input2);
            int n2 = Int32.Parse(input2);

            // 수식
            int result = n1 + n2;
            //Console.WriteLine("결과는 " + result);
            Console.WriteLine($"결과는 : {result}");
        }
    }
}
