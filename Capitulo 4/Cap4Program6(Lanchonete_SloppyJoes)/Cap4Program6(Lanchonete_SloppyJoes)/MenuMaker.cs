using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap4Program6_Lanchonete_SloppyJoes_
{
    class MenuMaker
    {
        public Random Randomizer;
        string[] Meats = { "Roast beeg", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] Condiments = { "yellow mostard", "brown mostard", "honey mostard", "mayo", "relish", 
                                "french dressimer"};
        string[] Breads = {"rye", "white", "wheat", "pumpernicke1", "italian bread", "a roll"};

        public string GetmenuItem()
        {
            string randomMeats = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];
            return randomMeats + " with " + randomCondiments + " on " + randomBreads; 
        }

    }
}
