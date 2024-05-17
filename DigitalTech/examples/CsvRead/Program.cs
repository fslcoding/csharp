string[] ReadInData = File.ReadAllLines("students.csv");

int rows = ReadInData.Length;
int columns = 2;

string[,] Data = new string[rows, columns];

string[] temp = new string[columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Data[i, j] = ReadInData[i].Split(',')[j];
    }
}

// print out data

for (int i = 0; i < Data.GetLength(0); i++)
{
    for (int j = 0; j < Data.GetLength(1); j++)
    {
        Console.Write($"{Data[i, j]}, ");
    }
    Console.WriteLine();
}
