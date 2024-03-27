
Print();
Print();
Print();

/* 
  Output will be:

  Inside Method One!
  Inside Method One!
  Inside Method One!
 */

int fourSquared = FourSquared();

Console.WriteLine(fourSquared);

/*
   Output will be:

   16
*/

int fiveSquared = Square(5);

Console.WriteLine(fiveSquared);

/*
   Output will be:

   25
*/

void Print() {
    Console.WriteLine("Inside Method One!");
}

int FourSquared() {
    return 4 * 4;
}

int Square(int number) {
    return number * number; 
}
