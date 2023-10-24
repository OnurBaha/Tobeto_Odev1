//Metot1
Add();

//Metot2, Parametreli Metot
var result = Add2(20, 30);
Console.WriteLine(result);

//Metot3, Default Parametreli Metot
var result2 = Add3();
Console.WriteLine(result2);

//Metot4, Ref Keyword
int number1 = 20;
int number2 = 100;
var result3 = Add4(ref number1, number2);
Console.WriteLine(result3);
Console.WriteLine(number1);





// Metot1
static void Add()
{
    Console.WriteLine("Added!");
}

//Metot2, Parametreli Metot
static int Add2(int number1, int number2)
{
    var result = number1 + number2;
    return result;
}

//Metot3, Default Parametreli Metot
static int Add3(int number1=10, int number2=30)
{
    var result2 = number1 + number2;
    return result2;
}

//Metot4, Ref Keyword
static int Add4(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}
