if (true)
{
    Console.WriteLine("Inside if!");
}

// == >= <= > < != && ||

if (false || true && false != true)
{
    Console.WriteLine(true);
}

string name = "Junseob";
if (name == "Junseob")
{
    Console.WriteLine("Hello Junseob!");
}
else if (name == "Iron Man")
{
    Console.WriteLine("Hello Iron Man");
}
else if (name == "Black Widow")
{
    Console.WriteLine("Hello Black Widow");
}

name = "Iron Man";
switch (name)
{
    case "Junseob":
        Console.WriteLine("Hello Junseob!");
        break;

    case "Iron Man":
    case "Black Widow":
        Console.WriteLine("Hello Black Widow");
        break;
}