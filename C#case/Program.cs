﻿using System;
using System.Runtime.InteropServices;

namespace consoleApp
{
    class program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            int numero_2 = 5;
            Console.WriteLine("quem é "+numero+"+"+numero_2+ "?");
            int resposta=Convert.ToInt32(Console.ReadLine());
            if (resposta == 15)
            {
                Console.WriteLine("parabens!! ");
            }
            else
                Console.WriteLine("tente de novo");

        }
    }
}