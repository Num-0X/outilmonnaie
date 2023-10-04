// Iverson
Console.WriteLine("Hello, World!");
Console.WriteLine("Choisissez votre monnaie (CAD/USD/EURO)");
string type = Console.ReadLine();
Console.WriteLine("Entrez un montant d'argent ");
double argent1 = Convert.ToDouble(Console.ReadLine());

if (type == "USD" || type == "usd")
{
    double argent2 = 1.35 + argent1;
    double argent21 = 1.432 * argent1;
    Console.WriteLine(argent1 + "USD équivaut à " + argent2 + "CAD");
    Console.WriteLine(argent1 + "USD équivaut à " + argent21 + "EURO");

    
}

if (type == "CAD" || type == "cad")
{
    double argent3 = 0.74 + argent1;
    double argent31 = 1.0475 * argent1;
    Console.WriteLine(argent1 + "CAD équivaut à " + argent3 + "USD");
    Console.WriteLine(argent1 + "CAD équivaut à " + argent31 + "EURO");

}

if (type == "EURO" || type =="euro")
{
    double argent4 = 1.432 * argent1;
    double argent41 = 1.0475 * argent1;
    Console.WriteLine(argent1 + "EURO équivaut à " + argent4+ "USD");
    Console.WriteLine(argent1 + "EURO équivaut à " + argent41 + "CAD");    
        
        }





// 1- Demander a l'utilisateur de choisir entre
//monnaie (A) OU (B)


// 2- Demander a l'utilisateur d'entrer le montant d'argent

// 3- Faire conversion de la monnaie

// CAD » US ou US » CAD