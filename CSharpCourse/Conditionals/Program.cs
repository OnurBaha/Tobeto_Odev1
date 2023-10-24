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
        Console.WriteLine("Number4 is 10!");
        break;
    case 20:
        Console.WriteLine("Number4 is 20!");
        break;
    case 30:
        Console.WriteLine("Number4 is 30!");
        break;
}

// Çoklu Şart Bloğu
var number5 = 150;

if (number5 >= 0 && number5 <= 100)
{
    Console.WriteLine("Number5 is between 0-100");
}
else if (number5 > 100 && number5 <= 200)
{
    Console.WriteLine("Number5 is between 100-200");
}
else if (number5 > 200 || number5 < 0) 
{
    Console.WriteLine("Number5 is less than 0 or greater than 200");
}

// İç İçe if Bloğu
var number6 = 20;

if (number6 <50)
{
    if(number6 >= 0 && number6 <= 20)
    {
        Console.WriteLine("Number6 is beetween 0-20");
    }
    else
    {
        Console.WriteLine("Number6 is between 21-50");
    }
}
