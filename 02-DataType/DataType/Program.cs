//https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
//https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

double age = 12.3;
float position = 45.6f; // float는 f를 붙여줘야 한다. 
Console.WriteLine(age);

int maxTest;
maxTest = int.MaxValue;
Console.WriteLine(maxTest);
maxTest++;
Console.WriteLine(maxTest);

string name = "Junseob";
Console.WriteLine("My name is " + name + " and I'm " + age + " years old.");
Console.WriteLine($"My name is {name} and I'm {age} years old.");

//Console.WriteLine("My name is "Junseob"");
Console.WriteLine("My name is \"Junseob\"");

char charcter = 'c';

bool isPlayer = true;
bool isEnemy = false;

var myVariables0 = 10;
var myVariables1 = 10.2;
var myVariables2 = 10.2f;
var myVariables3 = "10.2";
var myVariables4 = '1';
var myVariables5 = true;

// left to right
Console.WriteLine("Number" + 5 + 6);
Console.WriteLine(5 + 6 + "Number");

// int	-2,147,483,648 ~ 2,147,483,647
// long	-9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
int intVar = 10;
long longVar = 20;
//intVar = longVar; //error
longVar = intVar;

// float	±1.5 x 10^−45 ~ ±3.4 x 10^38
// double	±5.0 × 10^−324 ~ ±1.7 × 10^308
float floatVar = 12.3f;
double doubleVar = 45.6;
//floatVar = doubleVar; //error
doubleVar = floatVar;

intVar = (int)35.9f;
Console.WriteLine(intVar);

int health = 1;
int healthMax = 10;
Console.WriteLine(health / healthMax);
Console.WriteLine((float)health / healthMax);

int convertTestInt = Convert.ToInt32("12"); // 부호 있는 32비트 정수
long convertTestLong = Convert.ToInt64("34"); // 부호 있는 64비트 정수
Console.WriteLine(convertTestInt + ", " + convertTestLong);