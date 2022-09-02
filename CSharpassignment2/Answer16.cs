using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//16.Write a program in C# Sharp to display the pattern like right angle triangle with a number.
//The pattern like :

//1
//12
//123
//1234

namespace CSharpassignment2
{
    internal class Answer16
    {
        static void Main16()
        {

            int i, j, rows;

            Console.Write("\n\n");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
