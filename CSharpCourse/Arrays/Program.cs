//Diziler
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


// Çok Boyutlu Diziler
string[,] regions = new string[5, 3]
{
    {"İstanbul", "İzmit", "Balıkesir"},
    {"Ankara", "Konya", "Kırıkkale"},
    {"Antalya", "Adana", "Mersin"},
    {"Rize", "Trabzon", "Samsun"},
    {"Muğla", "İzmir", "Manisa"},
};

for(int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
        Console.WriteLine(regions[i, j]);
}