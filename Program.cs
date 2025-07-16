using System;
public interface IPrototype<T>
{
    T Clone();
}
public class Car : IPrototype<Car>
{
    public string Model { get; set; }
    public string Color { get; set; }

    public Car(string model, string color)
    {
        Model = model;
        Color = color;
    }

    public Car Clone()
    {
        return (Car)this.MemberwiseClone(); 
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Car Model: {Model}, Color: {Color}");
    }
}

class Program
{
    static void Main()
    {
        Car originalCar = new Car("Tesla Model S", "Red");
        Car clonedCar = originalCar.Clone(); 

        clonedCar.Color = "Blue"; 

        Console.WriteLine("Original Car:");
        originalCar.ShowDetails();

        Console.WriteLine("Cloned Car:");
        clonedCar.ShowDetails();
    }
}
