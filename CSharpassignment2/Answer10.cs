using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//10.Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria: 
//Marks in Maths >=65
//Marks in Phy >=55
//Marks in Chem>=50
//Total in all three subject >=180
//or
//Total in Math and Subjects >=140

//Test Data :
//Input the marks obtained in Physics :65
//Input the marks obtained in Chemistry :51
//Input the marks obtained in Mathematics :72


//Expected Output :
//The candidate is eligible for admission.


namespace CSharpassignment2
{
    internal class Answer10
    {
        static void Main10()
        {

            int p, c, m;

            Console.Write("\n\n");
            Console.Write("\n\n");

            Console.Write("Eligibility Criteria :\n");
            Console.Write("Marks in Maths >=65\n");
            Console.Write("and Marks in Phy >=55\n");
            Console.Write("and Marks in Chem>=50\n");
            Console.Write("and Total in all three subject >=180\n");
            Console.Write("or Total in Maths and Physics >=140\n");


            Console.Write("Input the marks obtained in Physics :");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry :");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics :");
            m = Convert.ToInt32(Console.ReadLine());

            if (m >= 65)
                if (p >= 55)
                    if (c >= 50)
                        if ((m + p + c) >= 180 || (m + p) >= 140)
                            Console.Write("The  candidate is eligible for admission.\n");
                        else
                            Console.Write("The candidate is not eligible.\n\n");
                    else
                        Console.Write("The candidate is not eligible.\n\n");
                else
                    Console.Write("The candidate is not eligible.\n\n");
            else
                Console.Write("The candidate is not eligible.\n\n");


            Console.ReadKey();
        }
    }
}
