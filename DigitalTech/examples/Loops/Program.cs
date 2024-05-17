public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("\nA While Loop:");

        // While Loop
        int j = 0;
        while(j <= 5) {
            Console.WriteLine(j);
            j++;
        }

        Console.WriteLine("\nA Do While Loop:");

        // Do While Loop

        int l = 0;
        do {
            Console.WriteLine(l);
            l++;
        }
        while(l < 5);


        Console.WriteLine("\nA For Loop:");


        // For Loop
        for(int i = 0; i < 10; i++) {
            Console.WriteLine(i);
        }
    }
}
