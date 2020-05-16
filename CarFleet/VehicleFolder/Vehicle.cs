using System;
using CarFleet.DriverFolder;
using System.Collections.Generic;

namespace CarFleet.VehicleFolder
{
    public abstract class Vehicle
    {
        private int id;
        private List<Driver> drivers;

        protected Vehicle(int id, List<Driver> drivers)
        {
            this.id = id;
            this.drivers = drivers;
        }

        public int Id { get => id; set => id = value; }
        public List<Driver> Drivers { get => drivers; set => drivers = value; }

        public abstract void GETDRIVERS();
    }
}
