using System.ComponentModel.Design;
using System.Runtime;

// Kobieta poniżej 30 lat
// Kobieta powyżej 33 lat
// Ewa, lat 33
// Niepełnoletni Mężczyzna
// Pełnoletni Mężczyzna

var name = "Ewa";
var age = 33;
var sex = "k";

if (sex == "k")
{
    if (age == 33)
    {
        if (name == "Ewa")
        {
            Console.WriteLine("Ewa, Lat 33");
        }
    }
    else
    {
        if (age < 30)
        {
            Console.WriteLine("Kobieta poniżej 30");
        }
        if (age > 33)
        {
            Console.WriteLine("Kobieta powyżej 33");
        }

    }
}
else if (sex == "m")
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni meżczyzna");
    }
    if (age > 18)
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
}


