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

////Metot5, Out Keyword
int number3;
int number4 = 100;
var result4 = Add5(out number3, number4);
Console.WriteLine(result4);
Console.WriteLine(number3);

//Metot6, Method Overloading
Console.WriteLine(Multiply(2,4));
Console.WriteLine(Multiply2(2, 4, 5));

//Metot7, Params Keyword
Console.WriteLine(Add6(1,2,3,4,5,6));



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


//Metot5, Out Keyword
static int Add5(out int number3, int number4)
{
    number3 = 30;
    return number3 + number4;
}

//Metot6, Method Overloading
static int Multiply(int number1, int number2)
{
    return number1 * number2;
}
static int Multiply2(int number1, int number2, int number3)
{
    return number1 * number2 * number3;
}


// Metot7, Params Keyword
static int Add6(params int[] numbers)
{
    return numbers.Sum();
}