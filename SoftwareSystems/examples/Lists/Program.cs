class Program {
    public static void Main(string[] args) {

        List<string> names = new List<string>();

        names.Add("Joshua");
        names.Add("Matthew");
        names.Add("Grace");

        foreach(string name in names) {
            Console.WriteLine(name);
        }
    }
}
