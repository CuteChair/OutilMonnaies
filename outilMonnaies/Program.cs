// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

double cad = 0, us = 0, eur = 0, choix = 0, choix2 = 0;
question:
Console.WriteLine("Bonjour, quelle est votre monnaie de départ? ");
Console.Write("Choisir entre CAD$ (1) ou USD$ (2) ou EUR :");
choix = Convert.ToDouble(Console.ReadLine());

   
    /*
    if (choix == 1)
    {
        Console.WriteLine("Vous avez choisi CAD!");
        Console.Write("Voulez vous convertir en USD (1) ou en EUR (2)?");
        choix2 = Convert.ToDouble(Console.ReadLine());
    cad = Convert.ToDouble(Console.ReadLine());
        us = cad * 0.74;
        Console.WriteLine($"Le montant {cad} CAD$ equivaut a {us} USD$ !");

    } 
   
    if (choix == 2)
    {
        Console.WriteLine("Vous avez choisi USD! ");
        Console.Write("Pour convertir en CAD entrer le montant :");
        us = Convert.ToDouble(Console.ReadLine());
        cad = us / 0.74;
        Console.WriteLine($"Le montant {us} USD$ equivaut a {cad} CAD$ !");
    }
    */
    if(choix == 3)
{
    Console.WriteLine("Vous avez choisi EUR! ");
    Console.Write("Voulez vous convertir en CAD (1) ou USD (2)?");
    choix2 = Convert.ToDouble(Console.ReadLine());
    if (choix2 == 1)
    {
        Console.WriteLine("Vous avez choisi CAD!");
        Console.Write("Entrez un montant :");
        eur = Convert.ToDouble(Console.ReadLine());
        cad = eur / 1.42;
        Console.WriteLine($"Le montant {eur} EUR equivaut a {cad} CAD$ !");
    }
    if (choix2 == 2)
    {
        Console.WriteLine("Vous avez choisi USD!");
        Console.Write("Entrez un montant :");
        eur = Convert.ToDouble(Console.ReadLine());
        us = eur / 0.95;
        Console.WriteLine($"Le montant {eur} EUR equivaut a {us} USD$ !");
    }
   
}

Console.ReadKey();



