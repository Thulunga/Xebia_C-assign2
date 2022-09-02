using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//9.Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies. 
//Test Data :
//Input the value for X coordinate :7
//Input the value for Y coordinate :9
//Expected Output :
//The coordinate point (7,9) lies in the First quadrant.

namespace CSharpassignment2
{
    internal class Answer9
    {
        static void Main9()
        {

            int co1, co2;

            Console.Write("\n\n");
            Console.Write("\n\n");

            Console.Write("Input the value for X coordinate :");
            co1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate :");
            co2 = Convert.ToInt32(Console.ReadLine());


            if (co1 > 0 && co2 > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the First quandrant.\n\n", co1, co2);
            else if (co1 < 0 && co2 > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Second quandrant.\n\n", co1, co2);
            else if (co1 < 0 && co2 < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Third quandrant.\n\n", co1, co2);
            else if (co1 > 0 && co2 < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Fourth quandrant.\n\n", co1, co2);
            else if (co1 == 0 && co2 == 0)
                Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n", co1, co2);

        

        Console.ReadKey();
        }
    }
}
