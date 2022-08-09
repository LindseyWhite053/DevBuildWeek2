string[] names = { "Abdul Amin", "Barbara Baker", "Cherine Cooper", "Douglas Dickerson", "Emily Emerson" };
int[] grades = { 95, 98, 85, 80, 70 };

// Print out all the grades
for (int i = 0; i <= 4; i++)
{
    Console.WriteLine($"{names[i]} has grade {grades[i]}");
}


//// Print out all the grades but slightly different for loop 
//Console.WriteLine();
//Console.WriteLine($"There are {names.Length} students.");
//for (int i = 0; i < names.Length ; i++)
//{
//    Console.WriteLine($"{names[i]} has grade {grades[i]}."); 
//}


////Ask the user which one to print out 
////This will print out the data in the index above the users input because Arrays start at 0
//Console.WriteLine("Please enter a number. ");
//string entry = Console.ReadLine();
//int num = int.Parse(entry);
//Console.WriteLine($"{names[num]} has grade {grades[num]}.");


//// Once the user has input their selection you must reduce it by 1 to get the correct index. 
//// Version1
//Console.WriteLine();
//Console.WriteLine("Please enter a number from 1 to 5. ");
//entry = Console.ReadLine();
//num = int.Parse(entry);
//num -- ; // Convert the number to an index
//Console.WriteLine($"{names[num]} has grade {grades[num]}.");


// Version2
bool okay = false;
int num = 0;
while (!okay)
{
    Console.WriteLine();
    Console.WriteLine("Please enter a number from 1 to 5. ");
    string entry = Console.ReadLine();
    bool validNum = int.TryParse(entry, out num);

    if (validNum)
    {
        if (num >= 1 && num <= 5)
        {
            okay = true;
        } 
    }
}

// This next code will run after they have entered a valid number. 
if (okay)
{
    num --;
    Console.WriteLine($"{names[num]} has grade {grades[num]}.");
} 