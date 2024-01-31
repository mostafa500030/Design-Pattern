using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
    public class SedanBasic : ICar
    {
        public void Display()
        {
            Console.WriteLine("Sedan Basic Car");
        }
    }
}
