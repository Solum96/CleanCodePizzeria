﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanCodePizzeria.Models;

namespace CleanCodePizzeria
{
    public class PizzeriaVisitor
    {
        public string VisitItem<T>(T item) => item switch
        {
            MenuItem menuitem => $"{menuitem.Title}: {menuitem.Price} kr",
            ExtraIngredient extra => $"{extra.Title}: {extra.Price} kr",
            Ingredient ingredient => ingredient.Title,
            Pizzeria pizzeria => VisitPizzeria(pizzeria),
            Order order => VisitOrder(order),
            _ => item.ToString(),
        };

        string VisitPizzeria(Pizzeria pizzeria)
        {
            var sb = new StringBuilder();

            sb.Append("Orders completed: ");
            foreach (var item in pizzeria.Orders.Select(o => o.Value).Where(o => o.Completed))
            {
                sb.Append(VisitOrder(item));
            }

            sb.Append("Orders in progress: ");
            foreach (var item in pizzeria.Orders.Select(o => o.Value).Where(o => !o.Completed))
            {
                sb.Append(VisitOrder(item));
            }
            return sb.ToString();
        }

        string VisitOrder(Order order)
        {
            var total = order.MenuItems.Sum(i => i.Price);
            var sb = new StringBuilder();
            if (order.ID != null) 
            {
                sb.Append($"Order [{order.ID}]");
                sb.Append(Environment.NewLine);
            } 

            foreach (var item in order.MenuItems)
            {
                sb.Append(VisitItem(item));
                sb.Append(Environment.NewLine);
                if (item is Pizza pizza)
                {
                    var extras = pizza.Ingredients.Where(i => (i is ExtraIngredient)).Select(i => VisitItem(i));
                    sb.Append(Environment.NewLine);
                    sb.Append("Extras: ");
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Join(Environment.NewLine, extras));
                    sb.Append(Environment.NewLine);
                }
            }

            sb.Append($"Total: {total}kr");
            sb.Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}
