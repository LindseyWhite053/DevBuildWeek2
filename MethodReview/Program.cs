
bool result = false;
while (!result)
{
    Console.WriteLine("Please enter an integer.");
    string entry = Console.ReadLine();

    int num;

    result = int.TryParse(entry, out num);

    if (result)
    {
        Console.WriteLine($"Great! Your number is {num}!");
    } else
    {
        Console.WriteLine($"Sorry, {entry} is not an integer");
    }
}