using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch = "남성";

            switch (ch)
            {
                case "남성":
                    Console.WriteLine("남성");
                    break;

                case "여성":
                    Console.WriteLine("여성");
                    break;

                default:
                    Console.WriteLine("알 수 없음");
                    break;
            }
        }
    }
}
