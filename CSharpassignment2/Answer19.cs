using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//19.Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1. 

//   1 
//  2 3 
// 4 5 6 
//7 8 9 10

namespace CSharpassignment2
{
    internal class Answer19
    {
        static void Main19()
        {
            int i, j, spc, rows, k, t = 1;

            Console.Write("\n\n");
            Console.Write("\n\n");

            Console.Write("input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.Write("\n");
                spc--;
            }

            Console.ReadKey();
        }
    }
}
