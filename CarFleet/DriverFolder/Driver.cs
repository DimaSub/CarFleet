﻿using System;

namespace CarFleet.DriverFolder
{
    public abstract class Driver
    {
        private int id;
        private string name;

        public Driver(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
