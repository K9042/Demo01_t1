﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teh1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;

            Console.Write("Anna luku 1, 2 tai 3. ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1) Console.WriteLine("Annoit luvun yksi.");
            else if (luku == 2) Console.WriteLine("Annoit luvun kaksi.");
            else if (luku == 3) Console.WriteLine("Annoit luvun kolme.");
            else Console.WriteLine("Joku muu luku.");
        }
    }
}
