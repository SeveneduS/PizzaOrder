using System.Collections.Generic;
using System.Text;

namespace PizzaOrder
{
    public class PizzaConfig
    {
        public static readonly List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza{ Name = "Pizza Barbarosa", Cost = 13.99f, Description = "Olives, onions, capers, tomatoes" },
            new Pizza{ Name = "Cheese Pizza", Cost = 24.99f, Description = "5 different chees" },
            new Pizza{ Name = "Hawaiian Pizza", Cost = 6.99f, Description = "Canadian bacon, pineapple." }
        };

    }

    public class Pizza
    {
        public string Name;
        public string Description;
        public float Cost;

        public override string ToString()
        {
            return $"{Name} : $ {Cost:0.00} : Description:[{Description}]";
        }

        public static string PizzaListToString(List<Pizza> list)
        {
            var sb = new StringBuilder();

            foreach (var p in list)
            {
                sb.Append(p);
            }

            return sb.ToString();
        }

        public static string OrderToString(Dictionary<Pizza, int> order)
        {
            var sb = new StringBuilder();

            foreach (var p in order)
            {
                sb.Append("[").Append(p.Value).Append("] ");
                sb.Append(p.Key);
            }

            return sb.ToString();
        }

        public static string OrderToString(KeyValuePair<Pizza, int> order)
        {
            var sb = new StringBuilder();

            sb.Append("[").Append(order.Value).Append("]");
            sb.Append(order.Key);

            return sb.ToString();
        }
    }
}
