// Let's start with a list for comparison
List<string> letters = new List<string>();
letters.Add("Abc");
letters.Add("Def");
letters.Add("Jkl");
letters.Add("Mno");

Console.WriteLine("Here are the letters");
foreach (string next in letters)
{
    Console.WriteLine(next);
}

//Initializing a Dictionary
//         Key      Value                         Key      Value
Dictionary<string, string> foods = new Dictionary<string, string>();
//The first listed is always the key and the second is the value in the pair. 
foods["Paul"] = "Spaghetti";
foods["Sarah"] = "Pizza";
foods["Quincy"] = "Tacos";
foods["Ruby"] = "Ice Cream";
foods["Terry"] = "Tacos";

//Let's print out Ruby's favorite food
Console.WriteLine(foods["Ruby"]);

//Paul changed his mind. He likes Hamburgers. 
foods["Paul"] = "Hamburgers";
Console.WriteLine($"Paul now likes {foods["Paul"]}");

//Do not assume a fixed order! If you need ordering, use a list.
foreach (var pair in foods)
{
    Console.WriteLine("The name and the food are:");
    Console.WriteLine(pair.Key); // The persons name
    Console.WriteLine(pair.Value); // The persons favorite food
}


// Check if an item exists in the dictionary
string entry = Console.ReadLine();
if (foods.ContainsKey(entry))
{
    Console.WriteLine($"Yes, we have a favorite food for {entry}");
    Console.WriteLine(foods[entry]);
} else
{
    Console.WriteLine("We don't know that person.");
}