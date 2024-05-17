# Try Catches

Try Catch Blocks are the basis of error-catching in C#


If you are running code which could result in an error, you should use a try catch

```csharp
try {
    string ReadIn = Console.ReadLine();
    int number = Convert.ToInt32(ReadIn);
}
catch(Exception ex) {
    Console.WriteLine("The following error occured " + ex.ToString() );
}
```

The **_Try_** block is the code to be tested. <br>
The **_Catch_** block is the code to be run if try errors.

<details>
    <summary>
        If the users enters the word "Five", what will be the Output?
    </summary>

    The following error occured System.FormatException

</details>

<details>
    <summary>
        If the users enters the word "5", what will be the Output?
    </summary>

    Success. Your age is 5

</details>


## Useful Links

[W3 Schools Exceptions](https://www.w3schools.com/cs/cs_exceptions.php)

# Tasks

Go back through your old code, and use try catch blocks to remove any errors.
