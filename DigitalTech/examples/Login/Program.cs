class Program
{
    public static void Main(string[] args)
    {
        string username, password;
        int numFails = 0;
        do
        {
            if (numFails == 0)
            {
                Console.Clear();
                Console.WriteLine("Enter username");
                username = Console.ReadLine();
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect login details entered. Please try again");
                Console.WriteLine("Enter username");
                username = Console.ReadLine();
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
            }
            numFails++;

        }
        while (!correctLoginDetails(username, password));
        Console.WriteLine("Login successful!");
    }

    public static bool correctLoginDetails(string username, string password)
    {
        bool correctPassword = false;

        if ((username == "username") && (password == "password"))
        {
            correctPassword = true;
            return correctPassword;
        }
        return correctPassword;
    }
}
