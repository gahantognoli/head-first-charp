﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap5Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Owen owner = new Owen();
            Safe safe = new Safe();

            JewelThief jewelThief = new JewelThief();
            jewelThief.OpenSafe(safe, owner);

            Console.ReadKey();
        }
    }
}
