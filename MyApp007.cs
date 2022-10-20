using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 250; // -128 ~ + 127, unsigned 0~255
            short s = b; // short : 2byte, -32,768~32,767, 묵시적 형변환
            s = 256;
            Console.WriteLine(s);

            ushort u = 65;
            char c = (char)u; // 명시적 형변환

            Console.WriteLine(c);

            int n = 40000;
            short s1 = (short)n;

            Console.WriteLine(s1);

        }
    }
}
