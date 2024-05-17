// Call both the good code and the bad code.

BadCode();
GoodCode();


void BadCode()
{
    string EnteredUsername;

    string EnteredPassword;

    bool IsRightUsername = false;

    while (!IsRightUsername)
    {
        Console.WriteLine("Username: ");
        EnteredUsername = Console.ReadLine()!;
        Console.WriteLine("Password: ");
        EnteredPassword = Console.ReadLine()!;

        if (EnteredUsername == "JCoulter123")
        {
            if (EnteredPassword == "Password10")
            {
                IsRightUsername = true;
            }
            else
            {
                Console.WriteLine("Your username or password is incorrect");
            }
        }
        else
        {
            Console.WriteLine("Your username or password is incorrect");
        }
    }

    Console.WriteLine("You have logged in!");

}


void GoodCode()
{
    while (true)
    {
        Console.WriteLine("Username: ");
        string EnteredUsername = Console.ReadLine()!;
        Console.WriteLine("Password: ");
        string EnteredPassword = Console.ReadLine()!;

        if (EnteredUsername != "JCoulter123")
        {
            Console.WriteLine("Incorrect Username or password");
            continue;
        }

        if (EnteredPassword != "Password10")
        {
            Console.WriteLine("Incorrect Username or password");
            continue;
        }

        break;
    }

    Console.WriteLine("You have logged in!");
}
