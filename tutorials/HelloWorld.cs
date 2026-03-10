public class Car
{
    public string Model {get; set;}
    public string Brand {get; set;}
    public int Year {get; set;}

    public Car(string model, string brand, int year)
    {
        Model = model;
        Brand = brand;
        Year = year;
    }

    public void TurnOnCar()
    {
        Console.WriteLine($"{Year} {Brand} {Model} was turned on.");
    }
}

class HelloWorld()
{
    static void Main(String[] args)
    {
        Car c = new Car("Corolla", "Toyota", 2001);
        c.TurnOnCar();
    }
}