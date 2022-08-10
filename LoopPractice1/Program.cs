string sentence = "";
string word = "";

do
{
    bool valid = false;
    while (!valid)
    {
        Console.WriteLine("Please enter a sentence: ");
        sentence = Console.ReadLine();

        if (sentence.Contains(" "))
        {
            valid = true;
        }
        else
        {
            Console.WriteLine("Make sure your sentence contains at least one space.");
        }

    }

    Console.Write("Please enter a word: ");
    word = Console.ReadLine();

    valid = false;
    while (!valid)
    {

        bool contains = sentence.ToLower().Contains(word.ToLower());

        if (word.Contains(" "))
        {
            Console.WriteLine("Make sure you only enter a single word with no spaces. ");
        }
        else
        {
            valid = true;
        }

        if (contains)
        {
            Console.WriteLine("Yep that word exists in the sentence!");
        }
        else
        {
            Console.WriteLine("Sorry, your word is not listed in that sentence.");
        }

    }

} while (KeepGoing());

Console.WriteLine("Thank you for playing!");

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
