using System;

// Interface
interface IMovable
{
    void Move();
}

// Car class
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Bicycle class
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();

        Console.WriteLine("Movement demonstration:");
        car.Move();
        bicycle.Move();

        Console.ReadKey();
    }
}