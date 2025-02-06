using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace InterfaceExercise
{
    class Program
    {
            public static void Main(string[] args)
            {
                //Creating objects for Car, Truck, and SUV
                var car = new Car
                {
                    CompanyName = "Car Company",
                    NumberOfWheels = 4,
                    FuelType = "Petrol",
                    TopSpeed = 220,
                    HasAirConditioning = true,
                    HasTrunk = true,
                    IsConvertible = false
                };

                var truck = new Truck
                {
                    CompanyName = "Truck Co.",
                    NumberOfWheels = 6,
                    FuelType = "Diesel",
                    TopSpeed = 180,
                    HasAirConditioning = false,
                    PayloadCapacity = 5000,
                    HasTowPackage = true
                };

                var suv = new SUV
                {
                    CompanyName = "SUV Motors",
                    NumberOfWheels = 4,
                    FuelType = "Hybrid",
                    TopSpeed = 200,
                    HasAirConditioning = true,
                    NumberOfSeats = 7,
                    HasFourWheelDrive = true
                };

                //Displaying details for each vehicle
                car.DisplayDetails();
                truck.DisplayDetails();
                suv.DisplayDetails();
            }
        }

    }
