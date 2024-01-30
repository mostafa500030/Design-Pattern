using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class Singleton
    {
        // Private static instance
        private static Singleton instance;

        // Private constructor to prevent instantiation
        private Singleton()
        {
            Console.WriteLine("Singleton instance created");
        }

        // Public method to get the singleton instance
        public static Singleton Instance
        {
            get
            {
                // Create the instance if it doesn't exist
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }

        // Other methods and properties of the singleton class
        public void DisplayMessage()
        {
            Console.WriteLine("Singleton instance is displaying a message");
        }
    }
}
