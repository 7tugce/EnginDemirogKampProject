// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// allias takma isim değer tutucu
string kategoriEtiketi = "Kategoriler oldu sonradan önceden kategoriydi"; // type safety 
//Console.WriteLine(  kategoriEtiketi);
int ogrenciSayisi = 32000;

double faizOrani = 1.45;

bool sistemeGirisYapmisMi = false;

double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine(  "Azalış butonu");

}else if (dolarDun < dolarBugun) { Console.WriteLine( "Artış butonu"  ); }
else { Console.WriteLine(  "değişmedi butonu"); }


if (sistemeGirisYapmisMi== true)
{
    Console.WriteLine("Kullanıcı ayarlar butonu");
}else
{
    Console.WriteLine("Giriş yap butonu");
}

Console.WriteLine(kategoriEtiketi);








