// See https://aka.ms/new-console-template for more information

using Bibliotek;

Faglitteratur BogenOmCSharp = new("Bogen om C# 9.0");

BogenOmCSharp.Forfatter = "Michell Cronberg";
BogenOmCSharp.Forlag = "Konsulentfirmaet M. Cronberg Aps. Allingtonvænget 32. 5270 Odense N. Mail: michell@cronberg.dk";
BogenOmCSharp.Udgivelsesår = 2021;
BogenOmCSharp.genre = (global::Bibliotek.Faglitteratur.Genre)3;

Skønlitteratur DenGrimmeÆlling = new("Den Grimme Ælling");

DenGrimmeÆlling.Forfatter = "H.C. Andersen";
DenGrimmeÆlling.Forlag = "Gyldendahl";
DenGrimmeÆlling.Udgivelsesår = 1843;
DenGrimmeÆlling.genre = (global::Bibliotek.Skønlitteratur.Genre)0;

//Bog[] mineBøger = new Bog[] { BogenOmCSharp, DenGrimmeÆlling };
Faglitteratur[] fagBøger = new Faglitteratur[] { BogenOmCSharp};
Skønlitteratur[] skønBøger = new Skønlitteratur[] { DenGrimmeÆlling };

//ANVENDES IKKE arrayet Bog, da det ikke vil give genre på underklasserne Faglitteratur og Skønlitteratur
//foreach (Bog x in mineBøger)
//{
//    Console.WriteLine(x.Titel);
//    Console.WriteLine(x.Forfatter);
//    Console.WriteLine(x.Forlag);
//    Console.WriteLine(x.Udgivelsesår);
//    Console.WriteLine("");
//}
 
foreach (Skønlitteratur x in skønBøger)
{
    Console.WriteLine(x.Titel);
    Console.WriteLine(x.Forfatter);
    Console.WriteLine(x.Forlag);
    Console.WriteLine(x.Udgivelsesår);
    Console.WriteLine(x.genre);
    Console.WriteLine("");
}

foreach (Faglitteratur x in fagBøger)
{
    Console.WriteLine(x.Titel);
    Console.WriteLine(x.Forfatter);
    Console.WriteLine(x.Forlag);
    Console.WriteLine(x.Udgivelsesår);
    Console.WriteLine(x.genre);
    Console.WriteLine("");
}