ShowCharacter();
MarkUp();
Celsius();
IsPrime();
//found help on stackoverflow
static void ShowCharacter()
{
    Console.WriteLine("Type any word");
    string name = Console.ReadLine();
    Console.WriteLine("Enter a number");
    int place = int.Parse(Console.ReadLine());
    Console.WriteLine(name[place]);
}
    static void MarkUp()
{
    Console.WriteLine("What is your cost?");
    double price = double.Parse(Console.ReadLine());
    Console.WriteLine("What is the percent markup?");
    double percent = double.Parse(Console.ReadLine());
    double markupCost = price * (percent / 100);
    double cost = price + markupCost;
    Console.WriteLine($"Your total is {Math.Round(cost,2)}.");
}

static void Celsius()
{
    for (int i = 80; i < 100; i++)
    {
        double tempC = (i - 32) * 5 / 9;
        Console.WriteLine(Math.Round(tempC, 2));
    }
}    

//found help on for loop help from w3resource.com
static void IsPrime()
{
    Console.WriteLine("Enter a number");
    int num = int.Parse(Console.ReadLine());
    for (int i = 2; i < num; i++)
    {
        if (num % i ==0)
        {
            Console.WriteLine("This is not a prime number.");
        }
        else
        {
            Console.WriteLine("This is a prime number.");
        }
    }
}