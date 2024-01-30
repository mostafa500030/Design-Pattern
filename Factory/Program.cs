namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the Sedan Car Factory to create a sedan
            ICarFactory sedanFactory = new SedanCarFactory();
            CarClient sedanClient = new CarClient(sedanFactory);
            sedanClient.Run();

            // Using the SUV Car Factory to create an SUV
            ICarFactory suvFactory = new SUVCarFactory();
            CarClient suvClient = new CarClient(suvFactory);
            suvClient.Run();
        }
    }
}