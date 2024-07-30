// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Kurs kurs1= new Kurs();  // kurs diye değişken tanımladın tipi kurs
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.IzlenmeOrani = 68;



Kurs kurs2 = new Kurs();  // kurs diye değişken tanımladın tipi kurs
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Kerem Varış";
kurs2.IzlenmeOrani = 78;


Kurs kurs3 = new Kurs();  // kurs diye değişken tanımladın tipi kurs
kurs3.KursAdi = "React";
kurs3.Egitmen = "Tuğçe Özelmaci";
kurs3.IzlenmeOrani = 7;


Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
// Console.WriteLine( kurs1); çıktı olarak kurs verdi

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };



foreach(var kurs in kurslar)
{
    Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
}

class Kurs
{
    public string  KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}