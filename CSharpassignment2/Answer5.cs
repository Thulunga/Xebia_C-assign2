using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//5.Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote. 
//Test Data : 21
//Expected Output:
//Congratulation! You are eligible for casting your vote.

namespace CSharpassignment2
{
    internal class Answer5
    {
        static void Main5()
        {

            int vote_age;
            Console.Write("\n\n");
            Console.Write("\n\n");


            Console.Write("Input the age of the candidate : ");
            vote_age = Convert.ToInt32(Console.ReadLine());
            if (vote_age < 18)
            {
                Console.Write("Sorry, You are not eligible to vote.\n");
                Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - vote_age);
            }
            else
                Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
        
            
        Console.ReadKey();
        }

    }
}
