using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpassignment2
{


    internal class Answer3
    {
        public static void Main3()
        {
            int num1, rem1;
            Console.Write("\n\n");
            Console.Write("\n\n");
            Console.Write("Input an integer : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 < 0)
                Console.WriteLine("{0} is an negative number.\n", num1);
            else
                Console.WriteLine("{0} is an positive number.\n", num1);


            Console.ReadKey();

        }

    }

}





