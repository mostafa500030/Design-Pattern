namespace singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Access the singleton instance
            Singleton singletonInstance1 = Singleton.Instance;
            Singleton singletonInstance2 = Singleton.Instance;

            // Both instances refer to the same object
            Console.WriteLine($"Are the instances the same? {singletonInstance1 == singletonInstance2}");

            // Use the singleton instance
            singletonInstance1.DisplayMessage();
            singletonInstance2.DisplayMessage();

            // Note: You can't create new instances using the private constructor
            // Singleton invalidInstance = new Singleton(); // This will result in a compilation error
        }
    }
}