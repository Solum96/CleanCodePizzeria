﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodePizzeria
{
    public abstract class MenuItem
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public MenuItem(string title, int price)
        {
            Title = title;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Title}: {Price} kr";
        }
    }

    public class Drink : MenuItem
    {
        public Drink(string title, int price): base(title, price)
        {
        }
    }
}