using System.Collections.Generic;

string[] isimler = new string[] { "Tuğçe", "Berkan", "Kübra", "Roza" };
Console.WriteLine(isimler[0]);
isimler = new string[5];// yeni array oluşturdun geri kalan elemanların hepsi silindi.
isimler[4] = "Pelin";


// <> generic yapı oluyor. 
List<string> isimler2 = new List<string> {"Tuğçe" , "Berkan", "Kübra","Roza" };
isimler2.Add("Pelin");
Console.WriteLine(isimler2[4]);

