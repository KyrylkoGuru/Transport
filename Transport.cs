using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class Transport
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public int Capacity { get; set; }
        public Transport(string brand, int speed, int capacity)
        {
            Brand = brand;
            Speed = speed;
            Capacity = capacity;
        }
        public virtual string GetInfo()
        {
            return $"{Brand} - Шкидкість: {Speed} км/год, Вмістимість: {Capacity}";
        }
    }
    public class Car : Transport
    {
        public string FuelType { get;}
        public Car(string brand, int speed, int capacity, string fuelType) : base(brand, speed, capacity) 
        { 
            FuelType = fuelType;
        }
        public override string GetInfo() 
        { 
            return $"Машина: {base.GetInfo()}, Пальне: {FuelType}";
        }
       
    }
    public class Bus : Transport
    {
        public int RouteNumber { get; set; }
        public Bus(string brand, int speed, int capacity, int routeNumber) : base(brand, speed, capacity)
        {
            RouteNumber = routeNumber;
        }
        public override string GetInfo()
        {
            return $"Автобус: {base.GetInfo()}, Маршрут №: {RouteNumber}";
        }
    }
    public class Bicycle : Transport
    {
        public bool HasGears { get; set; }
        public Bicycle(string brand, int speed, int capacity, bool hasGears) : base(brand, speed, capacity)
        {
            HasGears = hasGears;
        }
        public override string GetInfo()
        {
            return $"Велосипед: {base.GetInfo()}, Передачі: {(HasGears ? "Є" : "Немає")}";
        }
    }
}
