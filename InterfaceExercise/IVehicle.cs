using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        //Common properties for all vehicles
        int NumberOfWheels { get; set; }
        string FuelType { get; set; }
        int TopSpeed { get; set; }
        bool HasAirConditioning { get; set; }

        //Method displaying vehicle details
        void DisplayDetails();
    }

}
