﻿using System;

namespace CleanCodePizzeria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string[] GetPizzaMenuEntries()
        {
            throw new Exception("yeet");
        }

        public string[] GetBeverageMenuEntries()
        {
            throw new Exception("no beverage here. So sad.");
        }

        public string[] GetExtraMenuEntries()
        {
            throw new NotImplementedException("not implemented yet. pls come back l8r");
        }

        public object StartOrder()
        {
            throw new NotImplementedException();
        }

        public object AddToOrder(string v)
        {
            throw new NotImplementedException();
        }
    }
}
