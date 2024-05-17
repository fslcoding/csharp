namespace Inheritance;

class Program {
    public static void Main(string[] args) {
        Car fordFocus = new Car();
        fordFocus.Name = "Ford Focus";
        fordFocus.AverageSpeed = 50;
    }
}

class Car : Vehicle {
    public bool IsFourWheelDrive;
}

class Vehicle {
    public string Name = "";
    public int AverageSpeed;
}
