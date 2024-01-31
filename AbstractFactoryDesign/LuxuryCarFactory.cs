using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
    public class LuxuryCarFactory : ICarFactory
    {
        public ICar CreateSedan()
        {
            return new SedanLuxury();
        }

        public ICar CreateSUV()
        {
            return new SuvLuxury();
        }
    }
}
