// More fun with dictionaries 

// A list of salaries. The key will be a person's name (string),
// and the value will be the person's salary (decimal)

Dictionary<string, decimal> salaries = new Dictionary<string, decimal>();
salaries["Paul"] = 65000m;
salaries["Sarah"] = 100000m;
salaries["Quincy"] = 80000m;
salaries["Ruby"] = 65000m;
salaries["Terry"] = 60000m;
salaries["Fidan"] = 250000m;

//foreach (var pair in salaries)
//{
//    Console.WriteLine(pair.Key);
//}

foreach (string key in salaries.Keys)
{
    Console.WriteLine(key);
}

Console.Write("Please enter a name: ");
string name = Console.ReadLine();

if (salaries.ContainsKey(name))
{
    Console.WriteLine(salaries[name]);
} else
{
    Console.WriteLine("That person does not work here.");
}


Console.Write("Please add a new employee. Enter their name: ");
string name2 = Console.ReadLine();

Console.Write("Please enter a salary: ");
string entry = Console.ReadLine();
decimal salary = decimal.Parse(entry);

//Example 1 for adding a key, value pair
//salaries[name2] = salary;

// Example 2 for adding a new key value pair
salaries.Add(name2, salary);

Console.WriteLine("Here is everybody:");

foreach (var pair in salaries)
{
    Console.WriteLine($"{pair.Key} makes {pair.Value}");
}