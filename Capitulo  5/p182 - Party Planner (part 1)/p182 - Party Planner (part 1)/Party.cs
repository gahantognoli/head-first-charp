﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Party_planner
{
    class Party
    {
        public decimal CostOfDecorations = 0;
        private bool fancyDecorations;
        const int CostOfFoodPerPerson = 25;

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
        }

        private int numberOfPeople;
        public virtual int NumberOfPeople
        
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public virtual decimal CalculateCost()
        {
            decimal totalCost = CostOfDecorations + (CostOfFoodPerPerson* NumberOfPeople);

            if (NumberOfPeople > 12)
            {
                return totalCost += 100M;
            }
                return totalCost;
        }
    }
}
