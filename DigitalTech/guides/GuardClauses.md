# Why you should be a `Never Nester`

Nesting your code is bad. Here's how to fix it.

## What are Guard Clauses?

`Guard clauses` are a pattern in C# which can help improve the readability and understandibility of your code.

The core premise of `Guard Clauses` is that you should avoid nesting your code.

Instead you should employ **_early returns_** and **_Inversion_**

Take a look at some example code:

```cs
if(Username == "username1") {
    if(Password == "password1" ) {
        Console.WriteLine("You have logged in");
    }
    else {
        Console.WriteLine("You have entered an incorrect password");
    }
}
else {
    Console.WriteLine("You have entered an incorrect username");
}
```

Aside from the _security vulnerability_, what is bad about this code?

It may not seem that bad, but nesting your code even two times can make it much harder to read and understand.

Now consider having to use a loop to ask the user for their information. Now, the nesting would increase to 3.

Now take a look at the same code, but this uses `Guard Clauses`:

```cs
if(Username != "username1") {
    Console.WriteLine("You have entered the wrong username");
    return;
}

if(Password != "password1") {
    Console.WriteLine("You have entered the wrong password");
    return;
}

Console.WriteLine("You have logged in!");
```

In the above code, we can see that not only do we keep nesting to a minimum, it is easier to understand.

+ **_Early returns_** are employed in the above code. They can remove the need to `else` statements, which can in turn make your code much easier to digest.

+ The code also uses **_Inversion_** to flip the conditions, and allow for an **_early return_**

for example, `username == "username"` would become `username != "username"`.

When you start writing lots of code for one project, managing your code and it's simplicity becomes increasinly important.

## Useful Links

[Here](https://www.youtube.com/watch?v=CFRhGnuXG-4) is a great video by [CodeAesthetic](https://www.youtube.com/@CodeAesthetic) that goes into more depth about how to be a `Never Nester`.

[Here](https://www.youtube.com/watch?v=ZzwWWut_ibU) is another good video by [Flutter Mapp](https://www.youtube.com/@FlutterMapp). Much less in depth than the _Code Aesthetic_ video though.

# Tasks

+ Go back into your old code and change it to use `Guard Clauses`.
