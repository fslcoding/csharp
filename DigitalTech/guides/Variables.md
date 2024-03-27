# Variables

A variable is a **_Container_** for storing values.

### Creating Variables

A variable has:
+ A [data type](https://github.com/fslcoding/Data-Types)
+ A name
+ A value

If you do _not_ give the variable a value at creation, it is called **_Declaration_**
```cs
type name;
```

If you want, you can give it a value at creation, this is called **_Instantiation_**

```cs
type name = value;
```

**_Question_**

<details>
    <summary>
        How would you create an integer, called age, with a value of 15?
    </summary>

    int age = 15;

</details>

<br>
<br>

### Accessing Variables

To access a variable in your code, just call it's name:

```cs
Console.WriteLine(age);
```

<details>
    <summary>
        What would the output be?
    </summary>

    15

</details>


### Changing Variables

If you have a variable whose value you want to change, you can set one with:
```cs
name = value;
```
_N.B. No type is specified!_

### Advanced

If needed, you can declare multiple variables in one line,
however you will not be able to give them a value:
```cs
int x, y, z;
```


## Useful Links
[W3 Schools Variables](https://www.w3schools.com/cs/cs_variables.php) <br>
[Basic IO Video](https://www.youtube.com/watch?v=CaLJjQj2Fs4&list=PLxIdR4guOqDMs0rAnTW8XbFce4J7dHLJZ&index=1) <br>
[Data Types Video](https://www.youtube.com/watch?v=ZqjfYfv5cQc&list=PLxIdR4guOqDMs0rAnTW8XbFce4J7dHLJZ&index=3) <br>

# Tasks

**_Level One_**

+ Create some variables to store details about a user.
+ Print out the variables

**_Level Two_**
+ Read in two `integers` from the user and add them

**_Level Three_**
+ Read in two `integers` from the user and divide them
+ How would you store the result?
