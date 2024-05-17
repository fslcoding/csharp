# Loops

A summary of all the main types of loops


### _While Loop_

This loop is one of the simplest loops to understand.
The code inside will be run until the criteria is met.

A While Loop is **_entry controlled_**

This is what a while loop typically looks like:

```cs
int i = 0;

while(i < 5) {
    Console.WriteLine(i);
    i++;
}
```

Inside the ( ), there is a condition. This condition is checked at the start of every **_Iteration_**.

If the condition is met, then the code will stop looping.

<details>
    <summary>
        What will the code output?
    </summary>

    0 1 2 3 4

</details>

<details>
    <summary>
        What would the output be if the condition was changed to ( i <= 5 )?
    </summary>

    0 1 2 3 4 5

</details>






### Do While Loop

A do while loop is very similar to a while, but with one key difference,
it is **_Exit Controlled_**

This means that the condition is evaluated _after_ the code is run.

```csharp
int i = 0;

do {
    Console.WriteLine(l);
    l++;
}
while(l < 5);
```

The do while is different than the other loops because it's condition comes after the code.

The _main_ advantage of a do while is that the code will always run once, regardless of the condition.



### _For Loop_

This loop is used when you know how many times you want to loop through some code.
It is also one of the hardest loops to remember.

It is composed of **three** statements.

```csharp
int i = 0;
```

This Creates a _integer_ variable, which can only be used inside the loop. It stores the current **_Iteration_** of the loop. ( As a number )

The first time the loop _iterates_, this value will be 0,
The next time it will be 1, etc.

```csharp
i < 10
```

This is responsible for when the loop stops.

Every time the code loops, it checks if the statement is true, if it is, then the loops stops. If not, it keeps going.

```csharp
i++
```

The final step of the loop is responsible for increasing the counter ( In this case, ```i``` )

The syntax, ```++```, is called a **_Incrementor_**

Similarly to statement two, this is evaluated everytime the loop runs, however, this code adds one to the value of the integer, ```i```


All together, the loop looks like this:

```csharp
for( int i = 0; i < 10; i++ )
{
    Console.WriteLine(i);
}
```

<details>
    <summary>
        What will the result be?
    </summary>

    0 1 2 3 4 5 6 7 8 9

    Notice how the number 10 is NOT printed!

</details>

Now look at the following loop:

```csharp
for( int i = 10; i > 0; i-- ) {
    Console.WriteLine(i);
}
```

<details>
    <summary>
        What would the result be if you used the above loop instead?
    </summary>

    10 9 8 7 6 5 4 3 2 1

</details>

<br>

_For revision material on `Nested For Loops`, click [here](https://github.com/fslcoding/Loops/blob/main/RevisionMaterial/Docs/NestedFor.md)_


## Useful Links
[W3 Schools While Loop](https://www.w3schools.com/cs/cs_while_loop.php) <br>
[W3 Schools For Loop](https://www.w3schools.com/cs/cs_for_loop.php)


# Tasks

**_Level One_**
+ Make all the loops run backwards

**_Level Two_**
+ Print out the numbers 1 to 100, using a nested loop

**_Level Three_**
+ Print out all the elements of an array using a for loop
