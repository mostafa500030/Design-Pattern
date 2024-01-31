using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
     public interface ICarFactory
    {
        ICar CreateSedan();
        ICar CreateSUV();
    }
}
