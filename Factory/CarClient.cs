using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
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
            ICar car = carFactory.CreateCar();
            Console.WriteLine("Car created by the factory:");
            car.DisplayInfo();
        }
    }
}
