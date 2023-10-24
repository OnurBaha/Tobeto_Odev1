// if Bloğu
var number = 11;

if(number == 10)
{
    Console.WriteLine("Number is 10");
}
else
{
    Console.WriteLine("Number is not 10");
}


// Single Line
var number2 = 10;

Console.WriteLine(number2 == 10 ? "Number2 is 10" : "Number2 is not 10");



// else - if Bloğu
var number3 = 30;

if (number3 == 10)
{
    Console.WriteLine("Number3 is 10");
}
else if(number3 == 20)
{
    Console.WriteLine("Number3 is 20");
}
else
{
    Console.WriteLine("Number3 is not 10 or 20");
}

// switch Bloğu
var number4 = 20;

switch(number4)
{
    case 10:
        Console.WriteLine("Number is 10!");
        break;
    case 20:
        Console.WriteLine("Number is 20!");
        break;
    case 30:
        Console.WriteLine("Number is 30!");
        break;
}
