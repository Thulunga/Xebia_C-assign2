using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7.Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height. 
//Test Data : 135
//Expected Output :
//The person is Dwarf.

namespace CSharpassignment2
{
    internal class Answer7
    {
        static void Main7()
        {
            float PerHeight;
            Console.Write("\n\n");
            Console.Write("\n\n");

            Console.Write("Input the height (in centimetres):");
            PerHeight = Convert.ToInt32(Console.ReadLine());

            if (PerHeight < 150.0)
                Console.Write("The person is Dwarf. \n\n");
            else if ((PerHeight >= 150.0) && (PerHeight <= 165.0))
                Console.Write("The person is  average heighted. \n\n");
            else if ((PerHeight >= 165.0) && (PerHeight <= 195.0))
                Console.Write("The person is taller. \n\n");
            else
                Console.Write("Abnormal height.\n\n");

            Console.ReadKey();
        }
    }
}
