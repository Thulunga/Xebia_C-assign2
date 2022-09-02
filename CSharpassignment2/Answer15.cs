using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//15.Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk. 
//The pattern like :

//*
//**
//***
//****

namespace CSharpassignment2
{
    internal class Answer15
    {
        static void Main15()
        {
            int i, j, rows;
            Console.Write("\n\n");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }



            Console.ReadKey();
        }
    }
}
