// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

double cad = 0, us = 0, choix = 0;
question:
Console.WriteLine("Bonjour, quelle est votre monnaie de départ? ");
Console.Write("Choisir entre CAD$ (1) ou USD$ (2) :");
choix = Convert.ToDouble(Console.ReadLine());

   
    
    if (choix == 1)
    {
        Console.WriteLine("Vous avez choisi CAD!");
        Console.Write("Pour convertir en USD entrer le montant :");
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

Console.ReadKey();



