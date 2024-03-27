# String Methods

What is a string method?
A string method is a special type of method, which is 'attached' to the string class. 
They have been written by somebody else, but you can use them in your project.

These methods can be very useful at manipulating strings.

For all of the methods, you need to use the ```.``` after a string.

### **_ToUpper and ToLower_**

The ToUpper and ToLower methods change a string's characters to Uppercase and Lowercase, respectively.

```cs
string dt = "digital technology";
Console.WriteLine( dt.ToUpper() );
```

<details>
    <summary>
        What would the output be?
    </summary>
    
    DIGITAL TECHNOLOGY

</details>


```cs
string ssd = "SOFTWARE SYSTEMS DEVELOPMENT";
Console.WriteLine( ssd.ToLower() ); 
```


<details>
    <summary>
        What would the output be?
    </summary>

    software systems development

</details>


You can call these methods because **_they are strings_**


### **_Length_**

The ```Length``` method returns the amount of characters in a string.

```cs
string Joshua = "Coulter";
Console.WriteLine( Joshua.Length );
```


<details>
    <summary>
        What would the output be?
    </summary>

    7

</details>


### **_IsNullOrEmpty_**

This method checks if the string either has nothing in it, or is null;

!! This method is different to the others because you need to call the method from the string class.
```cs
string.IsNullOrEmpty(parameter);
```
Notice how the string you want to check is in the parameter. ( In between the brackets )



```cs
string TestOne = "";
Console.WriteLine( TestOne.IsNullOrEmpty() );

string TestTwo = " ";
Console.WriteLine( TestTwo.IsNullOrEmpty() );

string TestThree = "Hello, World!";
Console.WriteLine( TestThree.IsNullOrEmpty() );

string TestFour = null;
Console.WriteLine( string.IsNullOrEmpty(TestFour) );
```

<details>
    <summary>
        What would the outputs be?
    </summary>

    True
    False
    False
    True

</details>


### **_Split_**

The split method is used to convert a string into an array, by a character. 

```cs
string Message = "Hello World!";
string[] SplitMessage = Message.Split(' ');
```





<details>
    <summary>
In the above code, the string Message has one space. If the SplitMessage is splitting the string by a space, what will the values of the array be?
    </summary>

    "Hello", "World!"

</details>

**_BONUS QUESTION!_**

```cs
Console.WriteLine( SplitMessage[1] );
```

<details>
    <summary>
        What would the output of the above code be?
    </summary>

    World!

</details>

### **_Advanced String Techniques_**

**_String Interpolation_** is used to effeciently place variables inside a string.
It uses a ```$``` at the start.
```cs
string str1 = $"My Name is {name}, and I am {age} years old";
Console.WriteLine(str1);
// Output: My Name is Joshua, and I am 17 years old
```

**_IndexOf()_** returns the index of the specified char. If the char appears multiple times, it returns the first one. If it appears no times, it returns -1.
```cs
string str2 = "Hello, World!";
Console.WriteLine( str2.IndexOf('o') );
// Returns 4
```

**_Trim()_** removes any trailing whitespace from a string.
```cs
string str3 = "Hello World!   ";
Console.WriteLine( str3.Trim() );
// Output: Hello World!   // No spaces at end
```


## Useful Links
[W3 Schools Methods](https://www.w3schools.com/cs/cs_methods.php) <br>
[Video Walkthrough On IsNullOrEmpty](https://www.youtube.com/watch?v=YSqleXlBoJ8)

# Tasks

**_Level One_** 
+ Ask a user for their name and print the length

**_Level Two_**
+ Take in a string from the user
+ Make all vowels uppercase
+ Make all constanants lowercase

**_Level Three_**
+ Ask the user for a sentence
+ Take a string in from the user
+ Convert the sentence into an array of words
+ Print them back in reverse order
