using System;

public class Car
{
    private string model;
    private int year;

    public Car(string model, int year)
    {
        this.model = model;
        this.year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Model: {model}, Year: {year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", 2022);
        myCar.DisplayInfo();
    }
}
