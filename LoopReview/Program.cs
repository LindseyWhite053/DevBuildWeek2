string[] names = { "Abdul Amin", "Barbara Baker", "Cherine Cooper", "Douglas Dickerson", "Emily Emerson" };
int[] grades = { 95, 98, 85, 80, 70 };

bool okay = false;
int num = 0;
while (!okay)
{
	Console.WriteLine();
	Console.WriteLine("Please enter a number from 1 to 5.");
	string entry = Console.ReadLine();
	bool validNumber = int.TryParse(entry, out num);

	if (validNumber)
	{
		if (num >= 1 && num <= 5)
		{
			num--;
			okay = true;
		}
	}

}

// This next code will run after they have entered a valid number.
Console.WriteLine($"{names[num]} has grade {grades[num]}");

