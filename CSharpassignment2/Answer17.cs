using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//17.Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row. 
//The pattern like :

//1
//22
//333
//4444

namespace CSharpassignment2
{
    internal class Answer17
    {
        static void Main17()
        {
            int i, j, rows;

            Console.Write("\n\n");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", i);
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
