# Classes

Everything in C# is made up of classes and objects. This repo is a brief introduction into the concepts of classes.

**_What is a class?_**

A class is like a blueprint. Like a car needs a blueprint to be built, an object needs a class to be built.

### Creating a class

To create a class, we need the ```class``` keyword.

_A common naming convention is that all classes should start with a capital_

```cs
class ClassName { }
```

Classes are made up of **_Members_**. Members can be:
+ [Variables](https://github.com/fslcoding/Variables_CS "Variables Repo")
+ [Properties](https://github.com/fslcoding/Properties_CS "Properties Repo")
+ [Methods](https://github.com/fslcoding/Methods_CS "Methods Repo")

Look at [Car.cs](https://github.com/fslcoding/Classes_CS/blob/main/Car.cs "Car Class"), we can see it has two variables.
```cs
string Colour;
string CarName;
```

This means that every car will have a ```Colour``` and a ```CarName```.


### Instantiating an object

When you instantiate an object, you create a version of the specified class.

This is what that would look like.

```csharp
ClassName VariableName = new ClassName();
```

In [Program.cs](https://github.com/fslcoding/Classes_CS/blob/main/Program.cs "Program Class"), we create an object of the ```Car``` class.

```csharp
Car Ferrari = new Car();
```

To access a **_member_** of an object, you use the ``` . ``` syntax.

```csharp
// Car.cs
string CarName;

// Program.cs
Ferrari.CarName
```


<details>
    <summary>
        What would happen if you tried to access the Car's name?
    </summary>

    Car.CarName is unaccessable due to it's protection level.

</details>

### Accessibility Modifiers
There are 2 main types of accessibility:
+ ```public```
+ ```private```

**_Public_** means that the member _can_ be seen outside of the class. <br>
**_Private_** means that the member _cannot_ be seen outside of the class.

The above error occured because **_members, by default, are private_**

<details>
    <summary>
        How would you fix the error?
    </summary>

    public string CarName;

</details>

### Modifing a classes' members

Changing a classes' variable or _property_
```csharp
Ferrari.CarName = "Ferrari F8";
Ferrari.Colour = "Red";
```

### Methods in classes

You will almost always want to add a method to a class.
This is done in the exact same way as you would normally do it.

**_However_** unlike in GCSE, you should not make your methods ```static```, unless you want them to be.

Learn more about the [static keyword](https://github.com/fslcoding/static).

This is the basic template for how your methods should look like:

```csharp
AccessModifier Static? ReturnType MethodName ( Parameters ) {
    // Code in here
}
```

That might look intimidating, but in practice it looks like this:

```csharp
public int GetSpeed ( int distance, int time ) {
    return distance / time;
}
```

To call the method, you need to reference the class object, and then use the ```.``` syntax:

```cs
Car Ferrari = new Car();

Console.WriteLine ( Ferrari.GetSpeed ( 10, 2 ) ) ;
```

### Constructors

Constructors are methods that are called when **_an object is instantiated_**

The only difference between a method and a constructor is that a constructor **_does not have a return type_**

Here's the template for a constructor:

```csharp
public ClassName () {
    // Code in here
}
```

Here's an real-life example:
```cs
class Car {

    public Car () {
        name = "Ferrari";
    }

    string name;

}
```

In the code example above, we set the ```Car``` name to ferrari when we create the object

### Constructors with parameters

If we want to pass data to the object when it is instantiated, we should use parameters

Parameters work the same in constructors as in methods:

```csharp
public Car ( string CarName ) {
    name = CarName;
}
```

If we want to call this constructor, we call it at object instantiation:

```csharp
Car VariableName = new Car ( "Ferrari" );
```


## Useful Links

[W3 Schools OOP](https://www.w3schools.com/cs/cs_oop.php)<br>
[W3 Schools Classes](https://www.w3schools.com/cs/cs_classes.php)

## More Learning

+ [Properties](https://github.com/fslcoding/Properties_CS)
+ [Inheritance](https://github.com/fslcoding/Inheritance_CS)

# Tasks

**_Level One_**

+ Create a class called Person
+ Give each person a name, dob and gender
+ Create multiple people

**_Level Two_**

+ Create a list of people, for each person in your class
+ Iterate through them
+ Print the five oldest people in your class

**_Level Three_**

+ Add a method which calculates the person's age based on their date of birth.
+ Call this method in the constructor and store it in a private variable called ```Age```

**_Level Four (Hard)_**

+ Override the ToString method to print out the person's details in a string.

**_Level Five (Super Hard)_**

+ Implement the IComparable interface
+ Compare people by their age
+ Call ```Sort()``` on your list of classmates
