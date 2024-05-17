Console.WriteLine("This is a binary search");

int[] sortedArray = new int[10] { 1, 4, 6, 8, 19, 21, 24, 25, 30, 32 };
int number;
string value = "";
do
{
    Console.WriteLine("Enter the number you are searching for");
    value = Console.ReadLine()!;
}
while (Int32.TryParse(value, out number));


int result = BinarySearch(sortedArray, number);

if (result != -1)
{
    Console.WriteLine("Found number: " + result);
}
else
{
    Console.WriteLine("Could not find number");
}



static int BinarySearch(int[] sortedArray, int number)
{
    int min = 0;
    int max = sortedArray.Length - 1;

    while (min <= max)
    {
        int mid = (min + max) / 2;
        if (number == sortedArray[mid])
        {
            return ++mid;
        }
        else if (number < sortedArray[mid])
        {
            max = mid - 1;
        }
        else
        {
            min = mid + 1;
        }
    }
    return -1;
}

