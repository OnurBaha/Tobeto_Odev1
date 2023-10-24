//Metot1
Add();

//Metot2
var result = Add2(20, 30);
Console.WriteLine(result);




// Metot1
static void Add()
{
    Console.WriteLine("Added!");
}

//Metot2
static int Add2(int number1, int number2)
{
    var result = number1 + number2;
    return result;
}