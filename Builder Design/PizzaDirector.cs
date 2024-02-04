using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design
{
    public class PizzaDirector
    {
        private IPizzaBuilder pizzaBuilder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            pizzaBuilder = builder;
        }

        public void ConstructPizza()
        {
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
        }
    }
}
