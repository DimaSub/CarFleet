using System;
using CarFleet.DriverFolder;
using System.Collections.Generic;
using CarFleet.Enums;
using CarFleet.VehicleTypesFolder;

namespace CarFleet.WheeledVehicleFolder
{
    public sealed class Bicycle : WheeledVehicle
    {
        public Bicycle(int id, List<Driver> drivers, EnumVehicleType type) : base(id, drivers, type)
        {
        }

        public override void GETDRIVERS()
        {
            throw new NotImplementedException();
        }
    }
}
