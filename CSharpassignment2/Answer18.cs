using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//18.Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1.
//The pattern like :

//1
//2 3
//4 5 6
//7 8 9 10

namespace CSharpassignment2
{
    internal class Answer18
    {
        static void Main18()
        {
            int i, j, rows, k = 1;

            Console.Write("\n\n");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
