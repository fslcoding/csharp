# Methods

### Intro to methods

**_What are methods?_**
+ Methods store pieces of code that can be run at any point in your program.
+ Think of them like recipes, they are sets of instructions that you can use whenever you want.

**_But why use them?_**
+ Code reusability
+ Code modularity


### Creating methods

To create a method, follow this template:

```csharp
Type Name ( ) { }
```

The **_Type_** is what will be returned in your method. Most commonly this will be a ```void```, but it can be _any_ type.

When a method _returns_ something, it means that the method will give something back to where it was called from. A ```void``` return type means that it **_won't return anything_**.

[Learn more about types.](https://github.com/fslcoding/Data-Types)

The **_Name_** can be anything, it is a reference for you to call it.

All of your code will go inside the ```{ }```

To call the code, follow this template:

```csharp
Name( );
```

_N.B. When creating methods, they **must** be outside the main method, **but** inside the class._


<details>
    <summary>
        How would you create a method that: doesn't return anything, and is called Square
    </summary>

    void Square() { }

</details>


_For revision material on `Intro to methods`, click [here](https://github.com/fslcoding/Methods/blob/main/RevisionMaterial/Docs/IntroToMethods.md)_

### Method return types

A method can **_return_** a value after being called.

To do this you need to use the ```return``` keyword.

```csharp
int Square() {
    return 4 * 4;
}
```

The following code has a ```return``` type of ```int```, this means that it gives back an integer.

The ```return``` keyword is used to give back the result of ```4 * 4```

```csharp
int FourSquared = Square();
```

In the above code, we take the returned value from the ```Square()``` method, and store it in a variable, ```FourSquared```


<details>
    <summary>
        What would the result be?
    </summary>

    16

</details>


_For revision material on `Intro to return types`, click [here](https://github.com/fslcoding/Methods/blob/main/RevisionMaterial/Docs/IntroToReturnTypes.md)_

### Parameters

Sometimes when using methods, we want to pass data from the rest of our program to the method. We can acheive this by using **_Parameters_**.

**_Parameters_** go inside the ```( )``` in the method. 

Let's use this code to create a better ```Square``` method.

```csharp
int Square(int number) {
    return number * number;
}
```

In the above code, we take in an ```integer``` value from outside the method, and square it.


<details>
    <summary>
        How would you call the method?
    </summary>

    int FiveSquared = Square(5);

    // returns 25

</details>

We can pass _any_ variable that **_matches the type of the arguement_**

Here is a quick example of how you would:
+ Take input from user
+ Pass it into a method

```csharp
public static void Main(string[] args) {

    string FirstName = Console.ReadLine();
    int Age = Convert.ToInt32(Console.ReadLine());

    DisplayUserDetails(FirstName, Age);

}

void DisplayUserDetails(string name, int age) {

    Console.WriteLine("Your name is " + name + ", and your age is " + age );

}
```



<details>
    <summary>
        Joshua, Age 17 runs the program. What will the output be?
    </summary>

    Your name is Joshua and your age is 17

</details>

_For revision material on `Intro to parameters`, click [here](https://github.com/fslcoding/Methods/blob/main/RevisionMaterial/Docs/IntroToParameters.md)_


## Useful links

+ [W3 Schools Methods](https://www.w3schools.com/cs/cs_methods.php)


# Tasks

[_Fork_](https://github.com/fslcoding/HowToFork) and clone this code.

**_Level One_**

+ Create a method which takes in two integers, ```a``` and ```b```
+ Sum the two integers, and return the result

**_Level Two_**
+ Create a ```SquareRoot``` method, similar to the ```Square``` method


**_Level Three_**

+ Create a method called ```IsPrime```
+ Take in a number in the method parameter
+ Return true if the number is a prime number

**_Level Four_**

+ Create a method called ```CalculateFibonacci```
+ Take in a parameter ```n```
+ Generate fibonacci numbers up to the nth term
