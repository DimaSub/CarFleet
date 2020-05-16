using System;
using CarFleet.DriverFolder;
using System.Collections.Generic;
using CarFleet.Enums;

namespace CarFleet.VehicleTypesFolder
{
    public sealed class Kayak : NavalVehicle
    {
        public Kayak(int id, List<Driver> drivers, EnumVehicleType type) : base(id, drivers, type)
        {
        }

        public override void GETDRIVERS()
        {
            throw new NotImplementedException();
        }
    }
}
