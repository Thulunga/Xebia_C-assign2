using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2.Write a C# Sharp program to check whether a given number is even or odd.
//Test Data : 15
//Expected Output :
//15 is an odd integer

namespace CSharpassignment2
{


    internal class Answer2
    {
        public static void Main2()
        {
            int num1, rem1;
            Console.Write("\n\n");
            Console.Write("\n\n");
            Console.Write("Input an integer : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} is an even integer.\n", num1);
            else
                Console.WriteLine("{0} is an odd integer.\n", num1);
        
    
            Console.ReadKey();

            }

    }

}





