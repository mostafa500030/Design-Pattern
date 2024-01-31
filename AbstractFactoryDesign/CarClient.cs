using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
    public class CarClient
    {
        private readonly ICarFactory carFactory;

        public CarClient(ICarFactory carFactory)
         {
             this.carFactory = carFactory ?? throw new ArgumentNullException(nameof(carFactory));
         }

        public void Run()
        {
            ICar sedan = carFactory.CreateSedan();
            ICar suv = carFactory.CreateSUV();

            Console.WriteLine("Cars created by the factory:");
            sedan.Display();
            suv.Display();
        }
    }
}
