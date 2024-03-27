# Data Types

A data type ( commonly refered to as just '**_type_**' ), specifies the size of the variable, and what type of data it can store.

Here are some common types:

+ ```string``` stores many characters, eg. `"Hello, World!"`
+ ```char``` stores one character, eg. `'H'`
+ ```int``` stores a whole number, eg. `5`
+ ```double``` stores a decimal number, eg. `5.5`
+ ```bool``` stores either true or false, eg. `true`

Check out [examples/DataTypes]() to see examples of these types.

Some less common types include:

+ ```short``` half the size of ```int```
+ ```long``` double size of ```int```
+ ```float``` floating point number

### Converting between types

To convert between types, you use the ```Convert``` class, and you also need to use the ``` . ``` syntax.

Here is a basic example:

```csharp
string var1 = "5";

int var2 = Convert.ToInt32(var1);
```
var2 would be an integer of value 5.

_N.B. Converting is prone to errors, and you should always utilise a [**_Try Catch_**](https://github.com/fslcoding/Try_Catch_CS) when using them._

Another way to convert similar types is a [**_Cast_**](https://github.com/fslcoding/Casting_CS).

# Tasks

**_Level One_**
+ Read in the user's age
+ Convert it to an int
+ Print it back to them

**_Level Two_**
+ Do _level one_
+ Use a try catch, in a loop to keep asking the user for their age

**_Level Three_**
+ Use a TryParse to do _level one_
