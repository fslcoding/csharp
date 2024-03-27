# Arrays

Arrays are one of the most important ways to store data in C#. 

Arrays have three important rules.

+ Their **_index_** starts at 0
+ They have a **_fixed_** size
+ They can only store **_one_** data type

### Creating Arrays

Arrays are used to store multiple values in a single variable.

Think of them as a filing cabinet, you can access different drawers from one cabinet. 

In coding each of these drawers are values, and the cabinet is an array.

The template for an array looks like this:

```
type[] name = new type[size];
```

A basic **_string_** array with a size of 10 looks like this:

( A string array means that it stores only strings )

```
string[] StringArray = new string[10];
```

In the code above, we created an array. Inside the second square brackets, you tell the code the size of the array.


<details>
    <summary>
        How would you create an array of integers with a size of 5?
    </summary>

    int[] IntArray = new int[5];

</details>

<br>
<br>

The **_Index_** of an array is a values' position in the array.

**_Arrays' index starts at 0, so the first value in the array will be index 0_**

<br>

### Adding Data to Arrays

There are two ways to add values to an array.

**_Option One_**

```
string[] StringArray = new string[2] { "Joshua", "Coulter" };
```

The above code creates an _integer_ array which can store 2 values.
By placing ```{ }``` after the statement, we can add strings to the array, separated by commas.

N.B. You **_cannot_** add more strings than the allocated size of the array.

**_Option Two_**

```
string[] StringArray = new string[2];
StringArray[0] = "Hello";
StringArray[1] = "World!";
```

The second way of adding elements to an array is to access their position in the array.

The ```[ ]``` used in the second and third lines allows us to access a specific _index_ of an array. 


```
StringArray[2] = "Josh";
```

<details>
    <summary>
    What is wrong with the above code?
    </summary>
    
    The array only has a size of two, so there is no index of 2.

</details>



## Useful Links

[W3 Schools Arrays](https://www.w3schools.com/cs/cs_arrays.php)

# Tasks

For these tasks, fork the code.

**_Level One_**
+ Ask the user for a number
+ Print out the corresponding name
+ Use an if statement to check if the index is valid

**_Level Two_**
+ Make two arrays, one for fornames, and one for surnames.
+ Using a for loop, print out the forenames and surnames together.

**_Level Three_**
+ Create a two dimentional array
+ Ask the user for their name
+ Split their name into two
+ Add to the array

**_Level Four ( Super Hard )_**
+ Use a csv file to store names
