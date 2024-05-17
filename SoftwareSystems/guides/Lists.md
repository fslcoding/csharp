# Lists

Lists are very similar to [arrays](https://github.com/fslcoding/Arrays).

However, the key difference between lists and arrays are that **_Lists are not fixed in size_**.
They change their size dynamically based on their contents.

Similarly to arrays, **_They can only contain one [type](https://github.com/fslcoding/Data-Types)_**

_N.B. You may need to add ```using System.Collections.Generics;``` to your file._

### Creating a List

Creating a list looks like this:

```
List<type> Name = new List<type>();
```

You may notice that creating a list looks like creating an object, but with triangle brackets.
This is because a list is just an object that contains values.


The triangular brackets are called generics. [Learn more about generics](https://github.com/fslcoding/Generics).
<details>
    <summary>
        How would you create a list of strings, called "Names"?
    </summary>

    List<string> Names = new List<string>();

</details>
<br>

_N.B. You can always create a List without instantiation, ```List<type> Name;```_


### Adding elements to lists

```
ListName.Add(variable);
```

We are accessing a method of the ```List``` class called ```Add```.

Because lists do not have a fixed size, we can call this method as many times as we want.

### Accessing elements of lists

Exactly the same as arrays, you access an element in a list by:

```
ListName[Index];
```

### Useful list methods

+ ```Remove(T)``` - Removes the specified variable
+ ```RemoveAt(Int32)``` - Removes at the specified index
+ ```RemoveRange(Int32, Int32)``` - Removes the specified range of indecies
+ ```RemoveAll(Predicate<T>)``` - Removes all instances that match the predicate ([Delegates](https://github.com/fslcoding/Delegates))
+ ```Reverse()``` - Reverses the order of the list
+ ```Sort()``` - Sorts the elements of the list

## Useful links

+ [C# List Class](https://www.geeksforgeeks.org/c-sharp-list-class/)

# Tasks

[_Fork_](https://github.com/fslcoding/HowToFork) and clone this repo.

**_Level One_**
+ Create a list of peoples' names
+ Ask the user their name
+ If their name is on the list, tell them
+ If not, add them to the list
+ ( You may need to use a csv )

**_Level Two_**
+ Create a list of lists
+ Store first and second names in each list respectively
+ Create a menu system to view and add names.

**_Level Three_**
+ Create a ```Person``` class
    + Each person should have a: Forname, Surname, Age, Gender
+ Create a list of the ```Person``` class
+ Store them in a csv, and parse them back.
+ Create a menu where the user can edit specific details about a person.
