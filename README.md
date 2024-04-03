-C# is a program lang

-.Net is a fframewok
  CLR(Common Language untime
  Class Library

-CLR
translate IL(Intermediate lang to native code) , process is called just in time compilation

Architecture of .net apps
classes-building block , container with data and methods(move() and start())
data-state of app (make,model,color())

namespace-container of rrelated classes.field types , data for database
dll - dynamically linked libray

variable - a name given to a storage locatio in memory
constant-an immutable value
we use constants for safety.dont want to accidentally change important things.

decalre a variable, 
int number;     //type and identifier then semi colon
inter Number = 1; //case sensitive so num and Num arent the same
const flat Pi = 3.14f; // cant use variable unless we initialize it , const data type name and value

Identifiers
cannot start with number , cannot incluse whitespace,no reserve keywords(int) , use meaningful names. firstname is better than fn


Naming Conventions
Camel Case: firstName
Pascal Case :FirstName
Hungarian Notion : strFirstName //dont use in C# , used in C++

For local variables: Camel Case  ,  int number;
For Constant variables: Pascal Case  , const int MaxZoom = 5;



Primitive Types , each  maps to .net type . the more precision u need the more bytes.
byte,
short - int16,
int - int32,
long -int64,
float - single,
double,
decimal,
char,
bool-boolean

double is default, u can declare a float or decimal. float number = 1.3f or decimal number = 1.3m. double is default.

Non-primitiive Types
-string
-array
-enum
-class



Overflowing
255 is the largest num u can store in byte

byte number = 255;
number = number + 1; // will be 0, 

u can use checked keyword

checked
{
byte nnumber = 25;
number = number + 1;
}
the prrogram will throw an exception or will crash.




Scope- where a varaible/constant has meaning and is accessible
block is indicated by curly bracket.

{ 
byte a = 1;
{ byte b = 2;

:
byte c = 3;
}
}
}











