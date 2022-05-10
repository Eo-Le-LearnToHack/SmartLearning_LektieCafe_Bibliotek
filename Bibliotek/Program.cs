// See https://aka.ms/new-console-template for more information

using Bibliotek;

Faglitteratur BogenOmCSharp = new("Bogen om C# 9.0");
BogenOmCSharp.Forfatter = "Michell Cronberg";
BogenOmCSharp.Forlag = "Konsulentfirmaet M. Cronberg Aps. Allingtonvænget 32. 5270 Odense N. Mail: michell@cronberg.dk";
BogenOmCSharp.Udgivelsesår = 2021;
BogenOmCSharp.genre = (global::Bibliotek.Faglitteratur.Genre)3;

Faglitteratur KemiC = new("Organisk Kemi C");
KemiC.Forfatter = "Edward";
KemiC.Forlag = "University";
KemiC.Udgivelsesår = 2002;
KemiC.genre = (global::Bibliotek.Faglitteratur.Genre)0;


Skønlitteratur DenGrimmeÆlling = new("Den Grimme Ælling");
DenGrimmeÆlling.Forfatter = "H.C. Andersen";
DenGrimmeÆlling.Forlag = "Gyldendahl";
DenGrimmeÆlling.Udgivelsesår = 1843;
DenGrimmeÆlling.genre = (global::Bibliotek.Skønlitteratur.Genre)0;

Skønlitteratur MandenMedLeen = new("Manden med leen");
MandenMedLeen.Forfatter = "The death himself";
MandenMedLeen.Forlag = "Underworld";
MandenMedLeen.Udgivelsesår = 666;
MandenMedLeen.genre = (global::Bibliotek.Skønlitteratur.Genre)3;

Bog[] mineBøger = new Bog[] { BogenOmCSharp, DenGrimmeÆlling, KemiC, MandenMedLeen }; //Alle bøger er indtastet i arrayet. Rækkefølgen er underordnet.
// Faglitteratur[] fagBøger = new Faglitteratur[] { BogenOmCSharp}; //ikke nødvendig da Faglitteraturen kan refereres som en Bog
// Skønlitteratur[] skønBøger = new Skønlitteratur[] { DenGrimmeÆlling }; //ikke nødvendig da Skønlitteratur kan refereres som en Bog

uint count_fagBøger = 1;
uint count_skønBøger = 1;


Console.WriteLine("Liste over faglitterære bøger");
Console.WriteLine("....................................");
foreach (Bog x in mineBøger)
{
    if (x is Faglitteratur)
    {
        Console.WriteLine("");
        Console.WriteLine($"Bog nr. {count_fagBøger} på listen er:");
        Console.WriteLine(x.Titel);
        Console.WriteLine(x.Forfatter);
        Console.WriteLine(x.Forlag);
        Console.WriteLine(x.Udgivelsesår);
        Console.WriteLine(((Faglitteratur)x).genre); //Det er nødvendigt at fortælle at x er Faglitteratur en gang til for at tilgå genre som ikke finde is SUPERCLASS.
        Console.WriteLine("");
        count_fagBøger++;
    }
}
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Liste over skønlitterære bøger");
Console.WriteLine("....................................");
foreach (Bog x in mineBøger)
{
    if (x is Skønlitteratur)
    {
        Console.WriteLine("");
        Console.WriteLine($"Bog nr. {count_skønBøger} på listen er:");
        Console.WriteLine(x.Titel);
        Console.WriteLine(x.Forfatter);
        Console.WriteLine(x.Forlag);
        Console.WriteLine(x.Udgivelsesår);
        Console.WriteLine(((Skønlitteratur)x).genre); //Det er nødvendigt at fortælle at x er Skønlitteratur en gang til for at tilgå genre som ikke finde is SUPERCLASS.
        Console.WriteLine("");
        count_skønBøger++;
    }
}

