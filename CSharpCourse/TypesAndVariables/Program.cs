Console.WriteLine("Hello, World!");
//Value Types
int number1 = 2147483647;
long number2 = 9223372036854775807;
short number3 = 32767;
byte number4 = 255;
bool condition = false;
char character = 'A';
double number5 = 10.4;
decimal number6 = 21.7m;
var number7 = 10;
number7 = 'A';


Console.WriteLine("Number is {0}", number1);
Console.WriteLine("Number is {0}", number2);
Console.WriteLine("Number is {0}", number3);
Console.WriteLine("Number is {0}", number4);
Console.WriteLine("Character is {0}", (int)character);
Console.WriteLine("Number is {0}", number5);
Console.WriteLine("Number is {0}", number6);
Console.WriteLine("Number is {0}", number7);
Console.WriteLine((int)Days.Friday);

enum Days
{
    Monday , Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}