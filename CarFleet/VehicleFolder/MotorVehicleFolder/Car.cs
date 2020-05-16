using System;
using CarFleet.DriverFolder;
using System.Collections.Generic;
using CarFleet.Enums;
using CarFleet.WheeledVehicleFolder;

namespace CarFleet.MotorVehicleFolder
{
    public sealed class Car : MotorVehicle
    {
        public Car(int id, List<Driver> drivers, EnumVehicleType type) : base(id, drivers, type)
        {
        }
    }
}
