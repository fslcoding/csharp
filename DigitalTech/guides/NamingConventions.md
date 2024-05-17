# C# naming conventions

**_How do I name my stuff??_**

This is a styling guide for C# coding,
encouraged by Microsoft!

### General Rules:

**_Never abbreviate in names_**

**_Use meaningful and descriptive names_**

**_Avoid using single-letter names_**

### Variables

Use camelCase for your variable names

+ _camelCaseLooksLikeThis_

**_Do not do this:_**
```cs
string M = 5;
```
**_Do this instead_**
```cs
string milesToDestination = 5;
```

_We gain context on what the variable is_

### Methods

Methods should follow the same general guidelines as variables, and accurately describe what they do, BUT, they use PascalCase instead.

+ _PascalCaseLooksLikeThis_

**_Do not do this:_**

```cs
void dosomething(int x) { }
```

**_Do this instead_**

```cs
void SquareNumber(int number) { }
```

### Classes

Classes should also use PascalCase in their names

**_Don't do this:_**

```cs
class car { }
```

**_Do this:_**

```cs
class Car { }
```

### Advanced naming guides:

+ Interfaces should start with a capital `I`
+ Attributes types end with the word `Attribute`
+ Don't use two consecutive (`_ `) characters.
+ Use camelCase for methods arguements, local variables, and private fields
+ Use PascalCase for class names and method names


### Exceptions to the rules:

+ You should use single letter variable names for loop counters:

```csharp
for(int i = 0; i < Something; i++) { }
```

For more in depth detail: loop at [this](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md) repo by user [ktaranov](https://github.com/ktaranov)
