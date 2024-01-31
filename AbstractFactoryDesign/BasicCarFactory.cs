using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
    public class BasicCarFactory : ICarFactory
    {
        public ICar CreateSedan()
        {
            return new SedanBasic();
        }

        public ICar CreateSUV()
        {
            return new SuvBasic();
        }
    }
}
