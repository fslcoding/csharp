# IO

IO stands for Input, Output

### Output

The first thing you should learn is how to output to the _console_

```cs
Console.WriteLine();
```

You don't need to know what this means, just that it will output something to the console.

To output ```Hello, World!``` to the console, we would write this:

```cs
Console.WriteLine("Hello, World!");
```

**_The text must be between two ```" "``` ( Quotation Marks )_**


<details>
    <summary>
        How would you output, "Friend's School!" to the console?
    </summary>

    Console.WriteLine("Friend's School!");

</details>

### Input

If we want to take something in from the user, we use the following code:

```cs
Console.ReadLine();
```

To store the input, we need to use [variables](https://github.com/fslcoding/Variables).

```cs
string input = Console.ReadLine();
```


_N.B. ```Console.ReadLine()``` will always return a ```string```_


## Useful links

[W3 Schools Input](https://www.w3schools.com/cs/cs_user_input.php)

# Tasks

**_Level One_**

+ Ask the user for their name
+ Take in their name

**_Level Two_**

+ Take in the user's name
+ Store it in a variable 
+ Print it back out to them

**_Level Three_**

+ Take in the user's: name, age, school year, gender
+ Turn their details into one string, for example, ```Your name is Joshua, and you are 17 years old```
+ Print it back out to them
