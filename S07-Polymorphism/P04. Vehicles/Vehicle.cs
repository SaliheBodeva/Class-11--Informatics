﻿using System;
using System.Collections.Generic;
using System.Text;


public abstract class Vehicle
{
    protected Vehicle(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }

    public double FuelQuantity { get;  set; }
    public double FuelConsumption  { get;  set; }
    public abstract void Drive(double km);
    public abstract void Refuel(double litters);
}

