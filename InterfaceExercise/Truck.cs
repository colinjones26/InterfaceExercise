using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        //IVehicle properties
        public int NumberOfWheels { get; set; }
        public string FuelType { get; set; }
        public int TopSpeed { get; set; }
        public bool HasAirConditioning { get; set; }

        //ICompany properties
        public string CompanyName { get; set; }

        //Truck-specific properties
        public int PayloadCapacity { get; set; }
        public bool HasTowPackage { get; set; }

        //Implement DisplayDetails
        public void DisplayDetails()
        {
            Console.WriteLine($"Truck Details: ");
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Top Speed: {TopSpeed} km/h");
            Console.WriteLine($"Has Air Conditioning: {HasAirConditioning}");
            Console.WriteLine($"Payload Capacity: {PayloadCapacity} kg");
            Console.WriteLine($"Has Tow Package: {HasTowPackage}");
            Console.WriteLine();
        }
    }

}
