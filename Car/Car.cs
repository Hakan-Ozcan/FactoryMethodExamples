using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public abstract class Car
    {
        public abstract string CarType { get; }
        public abstract string Model { get; }
        public abstract string FuelType { get; }

        public void Drive()
        {
            Console.WriteLine($"This {CarType} car started driving with model {Model} and fuel type {FuelType} started driving.");
        }
    }
    public class Sedan : Car
    {
        public override string CarType => "Sedan";
        public override string Model => "Economy";
        public override string FuelType => "Gasoline";
    }

    public class SUV : Car
    {
        public override string CarType => "SUV";
        public override string Model => "Premium";
        public override string FuelType => "Dizel";
    }
    public abstract class CarFactory
    {
        public abstract Car CreateCar();
    }
    public class SedanFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new Sedan();
        }
    }

    public class SUVFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new SUV();
        }
    }



}
