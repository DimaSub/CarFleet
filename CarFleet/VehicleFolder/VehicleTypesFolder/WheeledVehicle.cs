using System;
using CarFleet.VehicleFolder;
using CarFleet.DriverFolder;
using System.Collections.Generic;
using CarFleet.Enums;

namespace CarFleet.VehicleTypesFolder
{
    public abstract class WheeledVehicle : Vehicle
    {
        private EnumVehicleType type;

        public WheeledVehicle(int id, List<Driver> drivers, EnumVehicleType type) : base(id, drivers)
        {
            this.type = type;
        }

        public EnumVehicleType Type { get => type; set => type = value; }
    }
}
