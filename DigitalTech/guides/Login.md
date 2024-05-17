# Login

This describes the code in the examples/Login folder.

The ```public static void Main(string[] args)``` method is run when the program begins.

It uses a ```do {} while()``` loop to ask the user for their details.
If the user enters wrong information, the program will add 1 to the variable which stores the number of fails, ```numFails++;```

```if (numFails == 0)```
This is an if statement, which makes it's code run _only_ on the first time executing the program.


Once the ```do {} while()``` loop has finished it's first loop, it will check if the entered details are correct. If they are not, it goes back to the start of the loop.

```while (!correctLoginDetails(username, password));``` This code is responsible for checking if the details are correct. It does this by running the ```correctLoginDetails()``` method.

After running the method, it [_inverses_](http://ctp.mkprog.com/en/csharp/logical_negation/) ( The '!' operator flips the bool value in front of it) the result of the method, and check if it is true.

If it is true, then it continues the loop.
If it is not true, then it stops the loop.


```public static bool correctLoginDetails(string username, string password)```

This method returns either ```true``` or ```false``` which is indicated by the ```bool``` keyword.

Inside the method, is a if statement. It checks if the username **and** password are correct, ( Indicated by the ```&&``` symbol).

If they are both correct, then return true.
If not, return false.


## Useful Links
[W3 Schools If Statements](https://www.w3schools.com/cs/cs_conditions.php) <br>
[W3 Schools While Loops](https://www.w3schools.com/cs/cs_while_loop.php)<br>
[W3 Schools Methods](https://www.w3schools.com/cs/cs_methods.php) <br>

# Tasks

[_Fork this code_](https://github.com/fslcoding/HowToFork "How To Fork")

**_Level One_**

+ Rewrite the code to use multiple usernames and logins. ( Maybe use an [array](https://github.com/fslcoding/Arrays)? )

**_Level Two_**

+ Store user login details in a csv file
+ Allow the user to add new logins

**_Level Three_**

+ Create a menu system, where the user can add, edit and delete logins.

**_Level Four ( Hard! )_**

+ Use a hashing algorithm to store login details securely
