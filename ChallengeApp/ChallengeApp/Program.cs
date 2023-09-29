using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;

var name = "Magda";
var sex = "female";
var age = 29;
if (age < 30)
    if (sex == "female" )
    {
    Console.WriteLine("KOBIETA PONIŻEJ 30 LAT");
    }
    else
    {
    Console.WriteLine("MĘŻCZYZNA PONIŻEJ 30 LAT");
    }
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("EWA LAT 33");
}
else if (sex != "female" && age < 18)
{
    Console.WriteLine("MĘŻCZYZNA NIEPEŁNOLETNI");
}





















