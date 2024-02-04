using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design
{
    public class MargheritaPizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public void BuildDough()
        {
            pizza.Dough = "Thin crust";
        }

        public void BuildSauce()
        {
            pizza.Sauce = "Tomato sauce";
        }

        public void BuildTopping()
        {
            pizza.Topping = "Cheese";
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
