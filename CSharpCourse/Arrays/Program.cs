string[] students = new string[3];
students[0] = "Engin";
students[1] = "Salih";
students[2] = "Derin";

string[] students2 = { "Ahmet", "Mehmet", "Ayşe" };

foreach(var student in students)
{
    Console.WriteLine(student);
}

foreach(var student in students2)
{
    Console.WriteLine(student); 
}