using System;

Vendeur vendeur;
Console.WriteLine("Voulez-vous utiliser des Htmls (1) ou des Pdfs (2) :");
var choix = Console.ReadLine();
if (choix == "1")
{
    liasseHtml = vendeur.creeAutomobile("html", "test", 6);
}
elif (choix == "2")
{
    laliassePdf = vendeur.creeAutomobile("pdf", "test", 6);
}
else
{
    Console.WriteLine(choix + "n'est pas un choix correct.");
}