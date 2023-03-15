


var name = "Adam";
char gender = 'm';    // może być więcej niż 2 opcje np. zmmiennokształtny kosmita z cipką i penisem 
var age = 17;


if (gender == 'f')
{
    Console.WriteLine("To jest Kobieta");
    if (age < 30)
    {
        Console.WriteLine("Poniżej 30 roku życia");
    }
    else if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("O imieniu Ewa lat 33");
    }
}
else if (gender == 'm')
{
    Console.WriteLine("To jest Mężczyzna");
    if (age < 18)
    {
        Console.WriteLine("On jest niepełnoletni");
    }   if (name == "Adam")
    {
        Console.WriteLine("Ma na imię Adam");
    }
    else if (age >= 18)
    {
        Console.WriteLine("On jest pełnoletni");
        if (name == "Jacek")
        {
            Console.WriteLine("Ma na imię Jacek");
        }
        else if (name == "Tomek")
        {
            Console.WriteLine("Ma na imię Tomek");
        }
    }

    // Trochę ogarniam xd


}





