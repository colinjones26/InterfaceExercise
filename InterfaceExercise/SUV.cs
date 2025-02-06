using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        //IVehicle properties
        public int NumberOfWheels { get; set; }
        public string FuelType { get; set; }
        public int TopSpeed { get; set; }
        public bool HasAirConditioning { get; set; }

        //ICompany properties
        public string CompanyName { get; set; }

        //SUV-specific properties
        public int NumberOfSeats { get; set; }
        public bool HasFourWheelDrive { get; set; }

        //Implement DisplayDetails
        public void DisplayDetails()
        {
            Console.WriteLine($"SUV Details: ");
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Top Speed: {TopSpeed} km/h");
            Console.WriteLine($"Has Air Conditioning: {HasAirConditioning}");
            Console.WriteLine($"Number of Seats: {NumberOfSeats}");
            Console.WriteLine($"Has Four Wheel Drive: {HasFourWheelDrive}");
            Console.WriteLine();
        }
    }

}
