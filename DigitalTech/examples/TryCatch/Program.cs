int age = 0;
bool isInvalidAge = true;

do
{
    try
    {
        Console.WriteLine("Please enter your age");
        age = Convert.ToInt16(Console.ReadLine());
    }

    catch (Exception ex)
    {
        Console.WriteLine("The following error ocurred " + ex.ToString());
    }

    if ( ( age > 1 ) && ( age < 18 ) )
    {
        isInvalidAge = false;
    }
}
while (isInvalidAge);

Console.WriteLine("Success. Your age is " + age.ToString());
