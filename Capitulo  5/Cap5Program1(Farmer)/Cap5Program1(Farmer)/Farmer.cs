﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap5Program1_Farmer_
{
    class Farmer
    {
        public int BagsOfFeed { get; private set; }
        public const int FeedMultiplier = 30;

        private int numberOfCows;
        public int NumberOfCows
        {

            get 
            {
                return numberOfCows;
            }

            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}
