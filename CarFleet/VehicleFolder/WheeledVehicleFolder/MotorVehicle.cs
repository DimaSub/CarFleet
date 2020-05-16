using System;
using CarFleet.DriverFolder;
using System.Collections.Generic;
using CarFleet.Enums;
using CarFleet.VehicleTypesFolder;

namespace CarFleet.WheeledVehicleFolder
{
    public class MotorVehicle : WheeledVehicle
    {
        public MotorVehicle(int id, List<Driver> drivers, EnumVehicleType type) : base(id, drivers, type)
        {
        }

        public override void GETDRIVERS()
        {
            throw new NotImplementedException();
        }
    }
}
