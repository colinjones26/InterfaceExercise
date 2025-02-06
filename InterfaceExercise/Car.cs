using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        // IVehicle properties
        public int NumberOfWheels { get; set; }
        public string FuelType { get; set; }
        public int TopSpeed { get; set; }
        public bool HasAirConditioning { get; set; }

        //ICompany properties
        public string CompanyName { get; set; }

        //Car specific properties
        public bool HasTrunk { get; set; }
        public bool IsConvertible { get; set; }

        //Implement DisplayDetailsw
        public void DisplayDetails()
        {
            Console.WriteLine($"Car Details: ");
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Top Speed: {TopSpeed} km/h");
            Console.WriteLine($"Has Air Conditioning: {HasAirConditioning}");
            Console.WriteLine($"Has Trunk: {HasTrunk}");
            Console.WriteLine($"Is Convertible: {IsConvertible}");
            Console.WriteLine();
        }
    }

}
