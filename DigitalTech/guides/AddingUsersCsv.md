# Adding a user to a CSV file

Index:

+ [Creating global variables](#creating-global-variables)
+ [The `Main()` Method](#the-mainstring-args-method)
+ [The `ReadInFile()` Method](#the-readinfile-method)
+ [The `AddUser()` Method](#the-adduser-method)
+ [The `WriteToFile()` Method](#the-writetofilestring-newusers-method)

## Creating global variables

The first thing we should do is to store some data about the user.

To start, we create three _global_ string variables. These will store the user's name and gender.

```cs
static string firstName, surname, gender;
```

Then we should also add three _global_ int variables.  These will store the user's age, score and year group

```cs
static int age, score, yearGroup;
```

<br>

Once we have our **_six_** pieces of information about the user, we should store this number in a variable. **_This will also be the amount of columns in the CSV_**

```cs
const int numDetails = 6;
```

The `const` keyword means that the value cannot change. We know that we will always have six values, so we can mark the variable as `const`

Learn more about [const](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const).

<br>

We should also store the location of the CSV file, so we can access it later.

**_If you are using Visual Studio_** this needs to be placed inside the **_bin/Debug/dotnet\*_** folder.

**_If you are using Visual Studio Code_** this needs to placed inside the same folder as your code.

```cs
static string location = "users.csv";
```

Also, we should store the number of users in the CSV file, so we can loop through them easier.

We will give this a value when we read in the CSV file.

```cs
static int numUsers;
```

<br>

Now we need to _instantiate_ two `arrays`, one which is 1D and one which is 2D.

Once again, we will also not give `User` a value until we get all the required information from the user.

And we will not give `Users` any values until we read them in from the CSV file.

```cs
static string[] User; // 1D

static string[,] Users; // 2D
```

<br>

## The `Main(string[] args)` Method

Inside the `Main(string[] args)` method, we first need to read in the CSV file from the user.

This will call the method to read in the file:

```cs
ReadInFile();
```

Then we should call the method to add a user to the CSV file.

```cs
AddUser();
```

_N.B. The `AddUser()` method will also call the `WriteToFile(string[,] newUsers)` method._

<br>

## The `ReadInFile()` Method

This method's job is to get all of the data from the CSV file, (`users.csv`).

First we need to create a new `array`, called `ReadInData`, equal to each row of the CSV file.

```cs
string[] ReadInData = File.ReadAllLines(location);
```

Next we set the `numUsers` equal to the amount of rows in the `ReadInData` `array`

```cs
numUsers = ReadInData.Length;
```

Now we should set the size of the `Users` `2D array`.
We set the rows equal to `numUsers`, and the columns equal to `numDetails`

```cs
Users = new string[numUsers, numDetails];
```

Finally, before the `for` loop, we need to create a `tempUser` `array` to store each individual user from the `ReadInData` `array`.

```cs
string[] tempUser = new string[numDetails];
```

Now the for loop. We iterate for the amount of users we have.

```cs
for(int i = 0; i < numUsers; i++) {
    // Code here
}
```

Inside the for loop, first we should give the `tempUser` `array` some values.
We split the `ReadInData` current `index`, by each comma.
This will give us each individual value for the specific user.

```cs
tempUser = ReadInData.Split(',');
```

Still in the `for` loop, we need another loop. This loop will actually populate the `Users` array.

```cs
for(int j = 0; j < numDetails; j++) {
    Users[i, j] = tempUser[j];
}
```

Finally, we can just print out that we have read in successfully.

```cs
Console.WriteLine("File has been read in successfully");
```


## The `AddUser()` Method

We should first greet the user to the program:

```cs
Console.WriteLine("Welcome to add a new user!");
```

Next, we should call a loop to input all of the user's details.

This loop is a `do { } while()` loop. It will call the loop once, and then loop it if the condition is true.

Learn more about [`do while loops`](https://github.com/fslcoding/Loops).

Below is an example of a loop to read in a first name from the user.

```cs
do {
    Console.WriteLine("Enter First Name: ");
    firstName = Console.ReadLine();
}
while(firstname == "");
```

The code above will read in the user's name. If the user didn't enter anything, the loop repeats.
<br>

We do the same code six times, to get all of the user's information.
<br>

_How would you make the code more effecient?_

At the end of `AddUser()`, we give the `string[] User`, a value.

We set the `User`'s size equal to the number of details that the user has ( **_six_** ).

```cs
User = new string[numDetails] { };
```

This will create an `array` with **_six_** values that we can access.

_However_, we also want to assign these values when we give the `array` a size.

To do this, we place our variables inside the `{ }`.

```cs
User = new string[numDetails]
{
    firstName, surname, gender, age.ToString(), score.ToString(), yearGroup.ToString()
};
```

In the code above, we pass all of our user's data to the `array`.

_Notice how we needed to convert the `int` variables to `string` because it is a `string[] array`._

<br>

After creating the `User` array, we need to create a new 2D `array` to **_Add the `User` array to the `Users` 2D array_**.

To do this, we should create the new `array` with a size of **_the amount of users + 1_**.

```cs
string[,] newUsers = new string[numUsers + 1, numDetails];
```

Next, lets add all of the values from `Users` to `newUsers`.

To do this, we should use a nested `for` loop:

```cs
for (int i = 0; i < Users.GetLength(0); i++) {
    for(int j = 0; j < numDetails; j++) {
        newUsers[i, j] = Users[i, j];
    }
}
```

_N.B. It is common practice to use `i` and `j` as counter variables._

The last thing to do is to add the new `User` to the end of the `array`:

```cs
for(int i = 0; i < numDetails; i++) {
    newUsers[numUsers, j] = User[j];
}
```

Above, we loop through the **_six_** element of the `array`, and add them to the end of the `newUsers` `array`

Finally, call the `WriteToFile(string[,] newUsers)` method, and pass the `newUsers` `array` through.

```cs
WriteToFile(newUsers);
```

## The `WriteToFile(string[,] newUsers)` Method

Writing to files can often result in errors, so we should wrap our code in a `try { } catch()`.

```cs
try {
    // Code here
}
catch(Exception ex) {
    Console.WriteLine("The following error occured: " + ex.ToString());
    // Restart the program.
    ReadInFile();
    AddUser();
}

Console.WriteLine("User file has been updated");
ReadInFile();
```

Inside the `try` block, we should use the `StreamWriter` `class` at the path to the CSV.

Inside the `using` statement, we should also use a nested `for` loop to loop through the `newUsers` array and write the values to the csv.

At the end of each row in the `array`, we write an empty line, so the next row will be on a new line.

In addition, we should add a comma at the end of each value, so that we can split it again later.

```cs
using (StreamWriter streamWriter = new StreamWriter(location)) {

    for(int i = 0; i < newUsers.GetLength(0); i++) {

        for(int j = 0; j < newUsers.GetLength(1); j++) {

            sw.Write(newUsers[i, j] + ",");

        }

        Console.WriteLine();
    }

}
```
