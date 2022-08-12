//EXERCISES: String Processing 23-30
//EXERCISES: Arrays 31-41

//EXERCISE 23
//Description: Prompt the user to enter a string.  Extract and output the first ten characters of the string.

//do
//{
//    Console.Write("Enter some text: ");
//    string input = Console.ReadLine();

//    string newString = input.Substring(0, 10);

//    Console.WriteLine($"The first ten characters were: {newString}");

//} while (KeepGoing());



//EXERCISE 24
//Description: Prompt the user to enter a string.  Extract and output the last ten characters of the string.

//do
//{
//    Console.Write("Enter some text: ");
//    string input = Console.ReadLine();

//	string newString = input.Substring(input.Length - 8);

//    Console.WriteLine($"The first ten characters were: {newString}");

//} while (KeepGoing());




//EXERCISE 25
//Description: Prompt the user to enter a sentence.  Split the sentence into individual words and display each word on its own line.

//do
//{
//	Console.Write("Enter some text: ");
//	string input = Console.ReadLine();

//	string[] newString = input.Split();

//	foreach (string word in newString)
//    {
//        Console.WriteLine(word);
//    }


//} while (KeepGoing());



//EXERCISE 26
//Description: Prompt the user to enter text.  Count and output how many vowels are in the string.

//int vowelCount = 0;
//int consCount = 0;

//do
//{
//	Console.Write("Enter some text: ");
//	string input = Console.ReadLine().ToLower();

//	foreach (char c in input)
//    {
//		if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'o' )
//        {
//			vowelCount++;
//        } else
//        {
//			consCount++;
//        }
//    }

//    Console.WriteLine($"There were {vowelCount} vowels in your text.");

//} while (KeepGoing());



//EXERCISE 27
//Description: Prompt the user to enter text.  Count and output how many consonants are in the string.


//do
//{
//	Console.Write("Enter some text: ");
//	string input = Console.ReadLine().ToLower();
//	char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
//	char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
//	int vowelCount = 0;
//	int consCount = 0;
//	int unknownCount = 0;

//	foreach (char c in input)
//	{
//		if (vowels.Contains(c))
//		{
//			vowelCount++;
//		} 
//		else if (consonants.Contains(c))
//		{
//			consCount++;
//		} else
//        {
//			unknownCount ++;
//        }
//	}

//	Console.WriteLine($"There were {consCount} consonants in your text.");

//} while (KeepGoing());




//EXERCISE 28
//Description: Prompt the user to enter text.  Remove all the vowels and output the text.

//char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
//char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

//do
//{
//	Console.Write("Enter some text: ");
//	string input = Console.ReadLine().ToLower();

//	foreach (char c in input)
//	{
//		if (vowels.Contains(c))
//		{
//			continue;
//		}
//		else 
//		{
//            Console.Write(c);
//		}

//	}

//	Console.WriteLine();

//} while (KeepGoing());



//EXERCISE 29
//Description: Prompt the user to enter text.  Remove all the vowels in the middle of the word, but leave any that start or end the word.

//char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

//do
//{
//	Console.Write("Enter some text: ");
//	string input = Console.ReadLine();

//	//Split input into an array of words
//	string[] words = input.Split(" ");

//	// Print first index 

//	// Print last index 
//	foreach (string word in words)
//    {

//        for (int i = 0; i < word.Length; i++)
//        {

//            // Print first index 
//            if (i == 0 )
//                {
//                    Console.Write(word[i]);
//                }
//			else if (i == word.Length - 1) // Print last index 
//			{
//				Console.Write($"{word[i]} ");
//			}
//			else if (vowels.Contains(word[i]))  // if the letter is a vowel skip
//            {		

//                continue;
//            }
//            else //else write it to the console
//            {
//				Console.Write(word[i]);
//			}

//        }

//    }

//	Console.WriteLine();

//} while (KeepGoing());



//EXERCISE 30
//Description: Prompt the user to enter text.  Reverse the text.

//do
//{
//    Console.Write("Enter some text: ");
//    string input = Console.ReadLine();

//	string newWord = "";

//	//Instantiate a stack
//	Stack<char> stackedWord = new Stack<char>();

//	//Use the stack to store characters
//	foreach (char c in input)
//	{
//		stackedWord.Push(c);
//	}

//    //Use the stack to retrieve characters in reverse order
//    for (int i = 0; i < input.Length; i++)
//    {
//        newWord = newWord + stackedWord.Pop();
//    }

//    Console.WriteLine(newWord);

//} while (KeepGoing());


//ARRAYS 

//EXERCISE 31
//Description: Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. Prompt the user to enter an index. Display the element in the array at that index.

//int[] nums = { 2, 8, 0, 24, 51 };

//do
//{
//    Console.Write("Enter an index of the array: ");
//    int input = int.Parse(Console.ReadLine());

//    Console.WriteLine($"The value at index {input} is {nums[input]}");

//} while (KeepGoing());



//EXERCISE 32
//Description: Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. Prompt the user to enter a number. If the number is in the array, display the index at which it is located.

//int[] nums = { 2, 8, 0, 24, 51};

//do
//{
//    Console.Write("Enter a number: ");
//    int input = int.Parse(Console.ReadLine());

//    if (nums.Contains(input))
//    {
//        Console.WriteLine($"The value {input} can be found at index {Array.IndexOf(nums, input)}");
//    }
//    else
//    {
//        Console.WriteLine("That value cannot be found in the array.");
//    }

//} while (KeepGoing());



//EXERCISE 33
//Description: Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. Let the user change the array by specifying an index and a replacement number.

//int[] nums = { 2, 8, 0, 24, 51 };
//do
//{

//	Console.Write("Enter an index of the array: ");
//	int input = int.Parse(Console.ReadLine());

//	Console.Write($"The value at index {input} is {nums[input]}. ");

//	bool startChange = StartChange(); 

//	if (startChange)
//	{
//		Console.Write("What would you like this value changed to?: ");
//		int newNum = int.Parse(Console.ReadLine());

//		nums[input] = newNum;
//		Console.WriteLine($"The value at index {input} is now {nums[input]}");
//	}
//	else if (!startChange)
//	{
//		Console.WriteLine("A change is will not be made.");

//	}

//} while (KeepGoing());



//static bool StartChange()
//{
//	while (true)
//	{
//		// Print out message asking if user wants to continue
//		Console.WriteLine("Would you like to change it (y/n)?");
//		// Ask the user for their input
//		string response = Console.ReadLine();
//		response = response.ToLower();
//		// Check if they typed "y". If so, return true.
//		// Otherwise return false.   YES   yes
//		if (response == "y" || response == "yes")
//		{
//			return true;
//		}
//		else if (response == "n" || response == "no")
//		{
//			return false;
//		}
//		else
//		{
//			Console.WriteLine("Please enter y or n");
//		}
//	}
//}



//EXERCISE 34
//Description: Create an array of size 5 and fill it with the following numbers: 16, 32, 64, 128, 256. Prompt the user to enter a command, 'half' or 'double'.  If the user enters 'half', half all the elements in the array.  If the user enters 'double', double all the elements in the array.

//int[] nums = { 16, 32, 64, 128, 256 };

//do
//{

//    Console.Write("Enter a command (half/double): ");
//    string input = Console.ReadLine().ToLower();

//	if (input == "half")
//    {
//		for (int i = 0; i < nums.Length; i++)
//		{
//			nums[i] /= 2;
//		}

//        Console.Write("The array now contains:");
//		for (int i = 0; i < nums.Length; i++)
//		{
//		Console.Write($" {nums[i]}");
//		}
//		Console.WriteLine(".");
//	}
//    else if (input == "double")
//    {
//		for (int i = 0; i < nums.Length; i++)
//		{
//			nums[i] *= 2;
//		}

//		Console.Write("The array now contains:");
//		for (int i = 0; i < nums.Length; i++)
//		{
//			Console.Write($" {nums[i]}");

//		}
//		Console.WriteLine(".");
//	}

//} while (KeepGoing());



//EXERCISE 35
//Description: Create an array of size 5 and fill it with the following strings: "cow", "elephant", "jaguar", "horse", "crow". Prompt the user to enter two indices separated by a space.  The first index will specify the word, and the second will specify a letter in that word.  Display the corresponding word and letter.

//string[] animals = { "cow", "elephant", "jaguar", "horse", "crow" };

//do
//{
//	//Prompt the user to enter two indices separated by a space.
//	Console.Write("Enter two indices: ");
//    string[] input = Console.ReadLine().Split();
//	int num1 = int.Parse(input[0]);
//	int num2 = int.Parse(input[1]);

//	Console.WriteLine($"The value at index {num1} is {animals[num1]}.  The letter at index {num2} is {animals[num2]}.");

//} while (KeepGoing());



//EXERCISE 36
//Description: Create two arrays, each of size 5. Fill the first array with the numbers: 12, 11, 10, 9, 8. Fill the second array with the strings: "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking". Combine both arrays to display a piece of the holiday song.


//int[] nums = { 12, 11, 10, 9, 8 };
//string[] storyCharacter = { "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking" };

//do
//{
//	for (int i = 0; i < storyCharacter.Length; i++) 
//	{
//        Console.WriteLine($"{nums[i]} {storyCharacter[i]}");
//    }


//} while (KeepGoing());



//EXERCISE 37
//Description: Prompt the user to enter five numbers.  Store these numbers in an array and output their sum.

//int[] nums = { 0, 0, 0, 0, 0 };

//do
//{
//	for (int i = 0; i < 5; i++)
//    {
//		Console.Write("Enter a number: ");
//		int input = int.Parse(Console.ReadLine());

//		nums[i] = input;

//    }

//	Console.Write($"Your numbers are");

//	foreach ( int num in nums)
//    {
//		Console.Write($" {num}");
//    }

//    Console.WriteLine(".");

//} while (KeepGoing());



//EXERCISE 38
//Description: Prompt the user to enter five numbers.  Store these numbers in an array and output their average.

//int[] nums = { 0, 0, 0, 0, 0 };

//do
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.Write("Enter a number: ");
//        int input = int.Parse(Console.ReadLine());

//        nums[i] = input;

//    }

//    Console.WriteLine($"The average of the numbers entered is :{nums.Average()}");

//} while (KeepGoing());




//EXERCISE 39
//Description: Prompt the user to enter five numbers.  Store these numbers in an array and output them in ascending order.

//int[] nums = { 0, 0, 0, 0, 0 };

//do
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.Write("Enter a number: ");
//        int input = int.Parse(Console.ReadLine());

//        nums[i] = input;

//    }

//	Array.Sort(nums);

//	foreach (int num in nums)
//    {
//        Console.WriteLine(num);
//    }


//} while (KeepGoing());




//EXERCISE 40
//Description: Prompt the user to enter five numbers.  Store these numbers in an array and output the median.

//int[] nums = { 0, 0, 0, 0, 0 };

//do
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.Write("Enter a number: ");
//        int input = int.Parse(Console.ReadLine());

//        nums[i] = input;

//    }

//    Array.Sort(nums);

//    Console.WriteLine($"The median of the array is {nums[nums.Length/2]}");

//} while (KeepGoing());



//EXERCISE 41
//Description: Prompt the user to enter two numbers.  Divide the two numbers and show only two decimal places.

//decimal[] nums = { 0, 0 };

//do
//{
//    for (int i = 0; i < 2; i++)
//    {
//        Console.Write("Enter a number: ");
//        decimal input = Convert.ToDecimal(Console.ReadLine());

//        nums[i] = input;

//    }

//	decimal quote = nums[0]/nums[1];
//	decimal roundedQuote = Math.Round(quote, 2);


//    Console.WriteLine($"{nums[0]}/{nums[1]} is approximately {roundedQuote}");

//} while (KeepGoing());













do
{

} while (KeepGoing());

static bool KeepGoing()
{
	while (true)
	{
		// Print out message asking if user wants to continue
		Console.WriteLine("Would you like to go again? (y/n)");
		// Ask the user for their input
		string response = Console.ReadLine();
		response = response.ToLower();
		// Check if they typed "y". If so, return true.
		// Otherwise return false.   YES   yes
		if (response == "y" || response == "yes")
		{
			return true;
		}
		else if (response == "n" || response == "no")
		{
			return false;
		}
		else
		{
			Console.WriteLine("Please enter y or n");
		}
	}
}