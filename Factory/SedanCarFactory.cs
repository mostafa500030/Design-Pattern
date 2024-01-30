using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class SedanCarFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Sedan();
        }
    }
}
