namespace Classes;

class Program {
    public static void Main(string[] args) {
        Car Ferrari = new Car();

        Ferrari.CarName = "Ferrari F8";
        Ferrari.Colour = "Red";

        Console.WriteLine(Ferrari.CarName);
        Console.WriteLine(Ferrari.Colour);

    }
}
