class MainClass
{
    public static void Main(string[] args)
    {
        bool again = true;
        int loanValue = 0;
        int noYears = 0;
        string userResponse = "";
        do
        {
            Console.WriteLine("Do you wish to check the cost of another loan- \"y\" or \"n\"?");
            userResponse = Console.ReadLine();
            if (userResponse == "y")
            {
                Console.WriteLine("Please enter you amount you wish to borrow");
                loanValue = Convert.ToInt16(Console.ReadLine());
                noYears = Convert.ToInt16(Console.ReadLine());
                double totalRepayable = calcCI(loanValue, noYears);
                Console.WriteLine("The final amount payable is " + totalRepayable);
            }
            else
            {
                Console.WriteLine("Thanks for using this application. Press any key to continue");
                Console.ReadKey();
                again = false;
            }
        }
        while (again);
        Console.WriteLine("the application has now terminated");
    }

    static double calcCI(int loanAmount, int numYears)
    {
        double interestRate = 0.05;
        double finalAmount = loanAmount;

        for (int i = 0; i < numYears; i++)
        {
            finalAmount = finalAmount + (finalAmount * interestRate);
        }

        return finalAmount;
    }
}
