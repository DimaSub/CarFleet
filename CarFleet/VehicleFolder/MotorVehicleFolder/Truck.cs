using System;
using CarFleet.DriverFolder;
using System.Collections.Generic;
using CarFleet.Enums;
using CarFleet.WheeledVehicleFolder;

namespace CarFleet.MotorVehicleFolder
{
    public sealed class Truck : MotorVehicle
    {
        public Truck(int id, List<Driver> drivers, EnumVehicleType type) : base(id, drivers, type)
        {
        }
    }
}
