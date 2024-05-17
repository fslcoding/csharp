class Car
{
    public string Name { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int NumSeats { get; set; }

    public Car(string name, string make, string model, int numSeats)
    {
        Name = name;
        Make = make;
        Model = model;
        NumSeats = numSeats;
    }
}
