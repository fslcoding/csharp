# Inheritance

Inheritance is very similar to real life.

Classes can inherit _fields_ and _methods_ from another class.

There are two types of classes involved in inheritance:
+ **_Base Class_** is the class being inherited from
+ **_Derived Class_** is the class that inherits from another class

The key syntax of inheritance is the ```:``` symbol:

```
class Car : Vehicle { }
```

Inheriting means that everything in the _Base Class_ has to be included in the _Derived Class_. In this case, every ```Car``` will contain fields and methods from ```Vehicle```


Look at [Vehicle.cs](https://github.com/fslcoding/Inheritance/blob/main/Vehicle.cs), there are two fields, ```Name``` and ```AverageSpeed```.

+ Every vehicle will have a Name and a Speed, so we can add those fields to a **_Base Class_**

```
class Vehicle {
    public string Name;
    public int AverageSpeed;
}
```

In the code above, we create a class called _Vehicle_ which contains two fields.

_N.B Private fields will not be inherited! ( They must be either public or protected. ) To learn more about access modifiers, check out the [repo](https://github.com/fslcoding/Access-Modifiers)!_


Look at [Car.cs](https://github.com/fslcoding/Inheritance/blob/main/Car.cs), we inherit both of the fields from the ```Vehicle``` class, _and_ we can add fields  exclusive to the ```Car``` class ( And it's derivatives! )

```
class Car : Vehicle {
    public bool IsFourWheelDrive;
}
```

In the ```Car``` class above, we derive it from Vehicle, and add another field, ```IsFourWheelDrive```

The field, ```IsFourWheelDrive``` is only in the Car class, because not every vehicle has 4 wheels, but every car does.

To create an object of Car, we do the same as a normal class.

```
Car fordFocus = new Car();
fordFocus.Name = "Ford Focus";
fordFocus.Speed = 120;
```

In the code above we can access the fields, because ```Car``` **_inherits_** from ```Vehicle```

_Derived Classes_ can also contain their own fields and methods, separate from their _Base Class_

```
bool IsFourWheelDrive;
```

<br>
<br>

When creating classes, always consider how you could use inheritance in your code.

## Useful links

[W3 Schools Inheritance](https://www.w3schools.com/cs/cs_inheritance.php)

# Tasks

[_Fork_](https://github.com/fslcoding/HowToFork) and clone this repo.

**_Level One_**

+ Add a ```AddFuel``` method to the vehicle class.
+ Create a car object and add fuel to it.

**_Level Two_**

+ Create a ```Motorcycle``` class that inherits from the Vehicle class.
+ Add a field, ```Fuel Capacity``` to the Vehicle class
+ _Instantiate_ both a Car and Motorcycle object with the following values.
    + A car has an average speed of 50mph, and a capacity of 55
    + A motorcycle has an average speed of 60mph and a capacity of 45
+ Have them race until they run out of fuel

**_Level Three_**

+ Create a new class, ```SUV```, and derive it from the ```Car``` class.
+ Create a flowchart of what your inheritance looks like.
