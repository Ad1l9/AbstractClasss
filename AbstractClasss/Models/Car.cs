﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasss.Models
{
    internal class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public bool IsElectricCar { get; set; }
        public Car(string factoryName, string model, int driveTime, int drivePath, int doorCount, bool isElectricCar) : base(factoryName, model, driveTime, drivePath)
        {
            DoorCount = doorCount;
            IsElectricCar = isElectricCar;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($@"Door count: {DoorCount},
Is electric car: {IsElectricCar}");
        }

        public override void DefineNatureHarmness()
        {
            if (IsElectricCar) Console.WriteLine("low");
            else Console.WriteLine("high");
        }
    }
}
