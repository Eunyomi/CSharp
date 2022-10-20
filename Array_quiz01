using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[3];

            Console.Write("kor : ");
            score[0] = Int32.Parse(Console.ReadLine());

            Console.Write("eng : ");
            score[1] = Int32.Parse(Console.ReadLine());

            Console.Write("math : ");
            score[2] = Int32.Parse(Console.ReadLine());

            double avg;
            int sum = 0;

            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }

            avg = (double)sum / 3.0; // 실수 / 정수 -> 실수

            Console.WriteLine($"sum : {sum}");
            Console.WriteLine($"avg : {avg}");
        }
    }
}
