﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Bronze bronzeCard = new Bronze(0.0, 150.0);
            if (bronzeCard.Turnover > 300.0) bronzeCard.DiscountRate = 0.025;
            else if (bronzeCard.Turnover >= 100) bronzeCard.DiscountRate = 0.01;
            Silver silverCard = new Silver(600.0, 850.0);
            if (silverCard.Turnover > 300) silverCard.DiscountRate = 0.035;
            Gold goldCard = new Gold(1500.0,1300.0);
            if(goldCard.Turnover>100)
            {
                if (goldCard.Turnover / 100 > 10) goldCard.DiscountRate = 0.10;
                else goldCard.DiscountRate = goldCard.Turnover / 10000;
            }
            Console.WriteLine(bronzeCard);
            Console.WriteLine(silverCard);
            Console.WriteLine(goldCard);

        }
    }
}
