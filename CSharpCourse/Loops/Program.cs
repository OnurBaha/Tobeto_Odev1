// For Döngüsü
for (int i = 100; i >= 0; i = i - 2)
{
    Console.WriteLine(i);
}
Console.WriteLine("Finished");


// While Döngüsü
int number = 100;
while (number >= 0)
{
    Console.WriteLine(number);
    number--;
}
Console.WriteLine("Now number is {0}", number);


// Do While Döngüsü
int number2 = 10;
do
{
    Console.WriteLine(number2);
    number2--;
} while (number2 >= 11);


// ForEach Döngüsü
string[] students = new string[3] { "Engin", "Derin", "Salih" };
foreach (var student in students)
{
    Console.WriteLine(student);
}



//IsPrimeNumber Example
if (IsPrimeNumber(6))
{
    Console.WriteLine("This is a prime number.");
}
else
{
    Console.WriteLine("This is a not prime number.");
}

static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}






