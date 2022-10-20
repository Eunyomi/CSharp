using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("width를 입력하세요 : ");
            string width_i = Console.ReadLine();
            Console.WriteLine(width_i);
            int width = Int32.Parse(width_i);

            Console.Write("height를 입력하세요 : ");
            string height_i = Console.ReadLine();
            Console.WriteLine(height_i);
            int height = Int32.Parse(height_i);

            double result = (double)(width * height) / 2.0;
            Console.WriteLine($"삼각형의 넓이는 : {result}");
        }
    }
}
