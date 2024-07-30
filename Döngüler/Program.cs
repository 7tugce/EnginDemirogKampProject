// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string kurs1 = "yawzılım";
string kurs2 = "programlamaya başlangıç için temel kurs";
string kurs3 = "java";

// array 

string[] kurslar = new string[]
{ "yawzılım" , "programlamaya başlangıç için temel kurs" ,"java"};

for(int i =0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine( "sayfa sonu ---- footer");


foreach(string kurs in kurslar)// kursları tek tek dolaş burdaki kurs alias
{
    Console.WriteLine( kurs);
}
















for (int i = 1; i < 10; i=i+2)// i+=2
{
    Console.WriteLine(i);
}