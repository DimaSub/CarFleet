using System;
using CarFleet.VehicleTypesFolder;
using CarFleet.VehicleFolder;
using CarFleet.DriverFolder;
using CarFleet.Enums;
using System.Collections.Generic;

namespace CarFleet
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select an option: ");


            Driver dima = new NavalDriver(123, "Dima");
            List<Driver> drivers = new List<Driver>();
            drivers.Add(dima);
            Vehicle ship = new Ship(456, drivers, EnumVehicleType.Naval);

        }
    }
}
