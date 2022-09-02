using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//12.Write a program in C# Sharp to display the multiplication table of a given integer. 
//Test Data :
//Input the number (Table to be calculated) : 15
//Expected Output :
//15 X 1 = 15...
//...
//15 X 10 = 150


namespace CSharpassignment2
{
    internal class Answer12
    {
        static void Main12()
        {
            int j, n;

            Console.Write("\n\n");
            Console.Write("\n\n");

            Console.Write("Input the number (Table to be calculated) : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }

            Console.ReadKey();
        }
    }
}
