namespace AbstractFactoryDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the Basic Car Factory to create basic sedan and SUV
            ICarFactory basicCarFactory = new BasicCarFactory();
            CarClient basicCarClient = new CarClient(basicCarFactory);
            basicCarClient.Run();

            // Using the Luxury Car Factory to create luxury sedan and SUV
            ICarFactory luxuryCarFactory = new LuxuryCarFactory();
            CarClient luxuryCarClient = new CarClient(luxuryCarFactory);
            luxuryCarClient.Run();
        }
    }
}