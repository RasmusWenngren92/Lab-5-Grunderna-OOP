﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class ReadInt
    {

        public static int ValidInput(string userInput)
        {
            while (true)
            {
                int number;
                if (int.TryParse(userInput, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Var god skriv in en siffra!");
                    userInput = Console.ReadLine();
                }
            }
        }
    }
}
