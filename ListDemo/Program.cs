// Let's make an array for comparison 
string[] myArray = {"abc", "def", "ghi"};

// Let's change one of the members
myArray[1] = "jkl";

// Let's loop through it
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}

Console.WriteLine();


// Now let's use a List. the data type is listed in "angle brackets" 
//Some functions modify the list. They actually do change the list itself, unlike string functions. 
List<string> myList = new List<string>();
myList.Add("Abc");
myList.Add("Def");
myList.Add("Ghi");

// Add an element 
myList.Add("Mno");

// Let's change an element 
myList[1] = "Jkl";



// Let's loop through it. Must use .Count instead of .Length whn using a list 
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}

Console.WriteLine( );

// Delete one from the list using the index 
myList.RemoveAt(2);
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}

Console.WriteLine();

// Remove one by name 
myList.Remove("Abc");
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}

Console.WriteLine();


// Insert one into the list 
myList.Insert(1, "Pqr");

// For each loop 
foreach (string word in myList)
{
    // Cannot see the index
    Console.WriteLine(word);
}

Console.WriteLine();

//lets sort the list 
myList.Sort();
foreach (string word in myList)
{
    // Cannot see the index
    Console.WriteLine(word);
}

Console.WriteLine();

// Let's check if one exists in the list 
Console.WriteLine("Type in a word and we'll see if it's in the list");
string input = Console.ReadLine();
int index = myList.IndexOf(input);
if (index >= 0)
{
    Console.WriteLine($"Found entry at {index}.");
} else
{
    Console.WriteLine("Entry is not in the list.");
}

Console.WriteLine();

// Initializing a new list 
List<int> numbers = new List<int>() { 5, 3, 8, 2 };
foreach(int nextnum in numbers)
{
    Console.WriteLine($"The next number is {nextnum}");
}

