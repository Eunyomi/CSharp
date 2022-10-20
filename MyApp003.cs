using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp003
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 50; // 변수 선언 및 초기화
            int n2; // 변수 선언
            n2 = 100; // 변수 초기화(값 대입)

            long sum = n1 + n2; // 수식(묵시적인 형변환)

            Console.WriteLine(sum);

            // Wrappger Class
            Int32 n3 = 50;
            Int32 n4 = 100;
            Int32 sum2 = n3 + n4;

            Console.WriteLine(sum2);

        }
    }
}
