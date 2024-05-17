using System;

class MainClass {
  public static void Main (string[] args)
  {
    Console.WriteLine ("*****INTEREST CALCULATOR*****\n");

    int pSum = 0;
    double interestRate = 0; //equivalent to 2/100
    int numY = 0;

    Console.WriteLine("Please enter the principal sum");
    pSum = Convert.ToInt16(Console.ReadLine());

    //After reading the interest rate in you need to convert to a % for use in this program i.e. divide by 100
    Console.WriteLine("Please enter the interest rate");
    pSum = (Convert.ToInt16(Console.ReadLine()))/100;

    Console.WriteLine("Please enter the number of years you wish to calculate the compound interest over");
    numY = Convert.ToInt16(Console.ReadLine());

    //This method call calls the simpleInterest method, passing the three parameter is requires to calculate simple interest.
    //It stores the 'return' value in a double simpleInterest used later in the output statement.
    double simpleInterest = calculateSimpleInterest(pSum, interestRate, numY);

    //This concatenates the various inputs into one output statement, stitching together variables with a string sentence
    Console.WriteLine("The total value of the principal sum " + pSum + " over " + numY + " years at an interest rate of " + interestRate + " using the SIMPLE INTEREST method is " + simpleInterest);

    //This method call, calls the compoundInterest method, passing the three parameter is requires to calculate compound interest.
    //It stores the 'return' value in a double compoundInterest used later in the output statement.
    double compundInterest = calculateCompoundInterest(pSum, interestRate, numY);

    //This concatenates the various inputs into one output statement, stitching together variables with a string sentence
    Console.WriteLine("The total value of the principal sum " + pSum + " over " + numY + " years at an interest rate of " + interestRate + " using the SIMPLE INTEREST method is " + compoundInterest);


  }

  //This method exists outside the main method and can be called at any time by the main method
  static double calculateSimpleInterest(int principalSum, double interestRate, int numYears)
  {
    //This sets the local variables ps, ir and ny equal to the value stored in the parameters passed through the method call above
    int ps = principalSum;
    double ir = interestRate;
    int ny = numYears;

    double finalAmount = 0;

    //This calculate simple interest in one line by adding the principal sum (ps) to the interest (ps*ir*ny).
    finalAmount = ps + (ps*ir*ny);

    return finalAmount;

  }
  //This method exists outside the main method and can be called at any time by the main method
  static double calculateCompoundInterest(int principalSum, double interestRate, int numYears)
  {
    double initialSum = principalSum;
    double ir = interestRate;
    int ny = numYears;

    double finalAmount = 0;

    for(int i =0;i<numYears;i++)
    {
      finalAmount=initialSum+(initialSum*ir);
      initialSum = finalAmount;
    }

    return finalAmount;
  }


}
