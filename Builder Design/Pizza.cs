using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }

        public void Display()
        {
            Console.WriteLine($"Dough: {Dough}, Sauce: {Sauce}, Topping: {Topping}");
        }
    }
}
