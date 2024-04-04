// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutakal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi]/ "Welcome, Ms. [kasuataja perekonnanimi]"

using System.ComponentModel.Design;

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your lastname:");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}