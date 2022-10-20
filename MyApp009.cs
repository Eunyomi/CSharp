using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            const int MAX_INT_BIT = 32; // const : 상수화
            MAX_INT_BIT = 64;
            Console.WriteLine(MAX_INT_BIT);
            */

            // 박싱 언박싱
            int a = 3;
            Int32 b = 6;
            a = b;
            b = a;

            int c = 5;
            double d = 7;
            //c = d; // Type이 맞지 않아 대입을 할 수 없다. 
            c = (int)d; // 명시적인 형변환
            d = c; // 묵시적인 형변환

        }
    }
}
