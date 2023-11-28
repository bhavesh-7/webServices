using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercive2client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the generated client proxy
            var client = new temp.Service1Client();

            // Get user input for Fahrenheit temperature
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Call the service method to convert temperature
            double celsius = client.FahrenheitToCelsius(fahrenheit);

            // Display the result
            Console.WriteLine($"{fahrenheit} Fahrenheit is equal to {celsius:F2} Celsius.");

            // Close the client
            client.Close();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
