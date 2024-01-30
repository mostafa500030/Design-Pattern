using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SUV : ICar
    {
        public void DisplayInfo()
        {
            Console.WriteLine("SUV Car");
        }
    }
}
