using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//20.Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk. 

//   *
//  * * 
// * * *
//* * * *

namespace CSharpassignment2
{
    internal class Answer20
    {
        static void Main()
        {

            int i, j, spc, rows, k;

            Console.Write("\n\n");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                spc--;
            }
            Console.ReadKey();
        }
    }
}
