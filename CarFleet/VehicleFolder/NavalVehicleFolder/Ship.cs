using System;
using CarFleet.DriverFolder;
using System.Collections.Generic;
using CarFleet.Enums;

namespace CarFleet.VehicleTypesFolder
{
    public sealed class Ship : NavalVehicle
    {
        public Ship(int id, List<Driver> drivers, EnumVehicleType type) : base(id, drivers, type)
        {
        }

        public override void GETDRIVERS()
        {
            throw new NotImplementedException();
        }
    }
}
