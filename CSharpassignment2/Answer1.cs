﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1.Write a C# Sharp program to accept two integers and check whether they are equal or not. 
//Test Data :
//Input 1st number: 5
//Input 2nd number: 5
//Expected Output :
//5 and 5 are equal


namespace CSharpassignment2
{


    internal class Answer1
    {
        public static void Main1()
        {
            int int1, int2;
            Console.Write("\n\n");
            Console.Write("Check whether two integers are equal or not:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input 1st number: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
                Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
        
            
            Console.ReadKey();

        }

    }

}





