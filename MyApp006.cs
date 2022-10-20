using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력 : ");
            string input = Console.ReadLine();
            Console.WriteLine(" ");
            int num = Int32.Parse(input);

            if ( num % 3 == 0 || num % 7 == 0)
            {
                Console.WriteLine("3 또는 7의 배수입니다.");
            }
            else
            {
                Console.WriteLine("3 또는 7의 배수가 아닙니다.");
            }
        }
    }
}
