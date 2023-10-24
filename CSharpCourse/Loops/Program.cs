// For Döngüsü
for(int i = 100; i>=0; i=i-2)
{
    Console.WriteLine(i);
}
Console.WriteLine("Finished");


// While Döngüsü
int number = 100;
while(number>=0)
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
}while(number2>=11);


// ForEach Döngüsü
string[] students = new string[3] { "Engin", "Derin", "Salih" };
foreach(var student in students)
{
    Console.WriteLine(student);
}