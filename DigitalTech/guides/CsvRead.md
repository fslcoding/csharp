# CSV Reading

This code is for reading a csv file into a [2D array](https://github.com/fslcoding/2D-Array).

## Code Breakdown

```
using System.IO;
```

This piece of code allows us to access the ```File``` class, which is necessary for reading a file.

```
string[] ReadInData = File.ReadAllLines("students.csv");
```
This code uses the ```File``` class to read everything in the specified [file](https://github.com/fslcoding/CSV-Read/blob/main/students.csv).

It returns all of those lines to the ```ReadInData``` array.

_Each line in the csv is a row in the array_

```
int rows = ReadInData.Length;
int columns = 2;
```

This creates a int variable called rows, which is set to the number of rows in ```ReadInData```

It also creates a variable called columns which is the number of columns in the csv.

```
string[,] Data = new string[rows, columns];
```

This creates a 2D array where the size is equal to the rows and columns of the csv


```
for(int i = 0; i < rows; i++) {
    for(int j = 0; j < columns; j++) {
        Data[i,j] = ReadInData[i].Split(',')[j];
    }
}
```

The double for loop iterates over every element once.
for each value, we add it to the corresponding place in the ```Data``` array.


```
ReadInData[i]    .Split(',')     [j];
```

First, we get the current value of ```i``` and get the corresponding string from the ```ReadInData``` array.

Then we split the string by commas, returning another array.

Finally we get the current index, ```j``` of the array, and set that equal to ```Data[i,j]```
