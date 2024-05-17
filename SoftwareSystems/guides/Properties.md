# Properties


Properties expand on the basic concept of ```Encapsulation```

Encapsulation is: **_Ensuring sensitive data is hidden from users_**

To achieve this, you must:
+ Declare fields / variables as ```private```
+ Provide ```public``` ```get``` and ```set``` methods, through **_properties_**, to access and update the value of a ```private``` field

## Basic Properties

This is what a basic property would look like:
```csharp
private string name;

public string getName() {
    return name;
}

public void setName(string name) {
    this.name = name;
}
```

In the code above, we can see that, **_name is private_**, BUT we can still access it through the appropriate methods.

This code is described as a ```property```

+ The ```get``` method returns the value of name
+ The ```set``` method assigns a value to the name variable

<details>
    <summary>
        How would you access the name from another class?
    </summary>

    string name = VariableName.getName();

</details>



<details>
    <summary>
        How would you change the name from another class?
    </summary>

    VariableName.setName("New Name");

</details>

**_Properties should always be used in your program_**

## Automatic Properties

C# has a quick way of declaring properties, where you do not have to define a field for the property.

This is what that looks like:

```csharp
public string Name { get; set; }
```

_N.B. It is best practice for properties to start with a capital_

## Why encapsulation?

+ Better control of class members
+ Fields can be made _read-only_
+ Flexible
+ Increased security of data


## Useful Links

[W3 Schools Properties](https://www.w3schools.com/cs/cs_properties.php)
