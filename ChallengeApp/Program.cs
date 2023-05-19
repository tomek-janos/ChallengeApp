

var name = "Tomek";
bool female = false;
var age = 3;


if (female == true)
{
    if (age > 30)
        if (name == "Ewa")
            Console.WriteLine("Ewa lat 33");
    if (age < 30)
        Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}