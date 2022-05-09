// See https://aka.ms/new-console-template for more information

using Bibliotek;

Faglitteratur BogenOmCSharp = new("Bogen om C# 9.0");

BogenOmCSharp.Forfatter = "Michell Cronberg";
BogenOmCSharp.Computer = "Programmering i C# for begyndere.";
BogenOmCSharp.Forlag = "Konsulentfirmaet M. Cronberg Aps. Allingtonvænget 32. 5270 Odense N. Mail: michell@cronberg.dk";
BogenOmCSharp.Udgivelsesår = 2021;

Skønlitteratur DenGrimmeÆlling = new("Den Grimme Ælling");

DenGrimmeÆlling.Forfatter = "H.C. Andersen";
DenGrimmeÆlling.Eventyr = "Eventyret om den grimme ælling som frovadler sig til en smuk svane.";
DenGrimmeÆlling.Forlag = "Gyldendahl";
DenGrimmeÆlling.Udgivelsesår = 1843;

Bog[] mineBøger = new Bog[] { BogenOmCSharp, DenGrimmeÆlling };

foreach (Bog x in mineBøger)
{
    Console.WriteLine(x.Titel);
    Console.WriteLine(x.Forfatter);
    Console.WriteLine(x.Forlag);
    Console.WriteLine(x.Udgivelsesår);

    
}

foreach (Faglitteratur y in mineBøger)
{
    Console.WriteLine(y.Computer);
}
Console.WriteLine("TEST");
foreach (Skønlitteratur z in mineBøger)
{
    Console.WriteLine(z.Eventyr);
}