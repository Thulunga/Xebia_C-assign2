using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//14.Write a program in C# Sharp to display the n terms of odd natural number and their sum. 
//Test Data
//Input number of terms : 10
//Expected Output :
//The odd numbers are :1 3 5 7 9 11 13 15 17 19
//The Sum of odd Natural Number upto 10 terms : 100


namespace CSharpassignment2
{
    internal class Answer14
    {
        static void Main14()
        {
            int i, n, sum = 0;
            Console.Write("\n\n");
            Console.Write("\n\n");

            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum);
        
        Console.ReadKey();
        }
    }
}
