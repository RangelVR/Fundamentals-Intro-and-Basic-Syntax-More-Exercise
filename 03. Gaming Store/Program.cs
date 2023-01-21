double money = double.Parse(Console.ReadLine());
string command = Console.ReadLine();

double OUTOFFALL4 = 39.99;
double CSOG = 15.99;
double ZPLINTERZELL = 19.99;
double HONORED2 = 59.99;
double ROVERWATCH = 29.99;
double ROVERWATCH_O_E = 39.99;


double totalSpend = 0;

while (command != "Game Time")
{
    switch (command)
    {
        case "OutFall 4":
            if (OUTOFFALL4 <= money)
            {
                Console.WriteLine("Bought OutFall 4");
                money -= OUTOFFALL4;
                totalSpend += OUTOFFALL4;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;

        case "CS: OG":
            if (CSOG <= money)
            {
                Console.WriteLine("Bought CS: OG");
                money -= CSOG;
                totalSpend += CSOG;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;

        case "Zplinter Zell":
            if (ZPLINTERZELL <= money)
            {
                Console.WriteLine("Bought Zplinter Zell");
                money -= ZPLINTERZELL;
                totalSpend += ZPLINTERZELL;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;

        case "Honored 2":
            if (HONORED2 <= money)
            {
                Console.WriteLine("Bought Honored 2");
                money -= HONORED2;
                totalSpend += HONORED2;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;

        case "RoverWatch":
            if (ROVERWATCH <= money)
            {
                Console.WriteLine("Bought RoverWatch");
                money -= ROVERWATCH;
                totalSpend += ROVERWATCH;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;

        case "RoverWatch Origins Edition":
            if (ROVERWATCH_O_E <= money)
            {
                Console.WriteLine("Bought RoverWatch Origins Edition");
                money -= ROVERWATCH_O_E;
                totalSpend += ROVERWATCH_O_E;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;

        default:
            Console.WriteLine("Not Found");
            break;
    }

    if (money == 0)
    {
        Console.WriteLine("Out of money!");
        break;
    }

    command = Console.ReadLine();
}

if (money > 0)
{
    Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${money:f2}");
}
