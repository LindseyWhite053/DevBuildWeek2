// An array is a variable that can hold a list of things

int[] grades = {100, 80, 100, 60, 85};

Console.WriteLine(grades[0]); // Expect 100
Console.WriteLine(grades[1]); // Expect 80
Console.WriteLine(grades[4]); // Expect 85

string[] names = { "Fred", "Jamal", "Yasmine", "Ziggy" };
Console.WriteLine(names[0]); // Expect Fred
Console.WriteLine(names[2]); // Expect Yasmine


Console.WriteLine();
int index = 3;
Console.WriteLine(names[index]); // Expect to see Ziggy


Console.WriteLine();
for (int ind = 0; ind < 4; ind++)
{
    Console.WriteLine(names[ind]);
}

Console.WriteLine();
//Same thing, but let's use <= 3 instead. Jeff usually does it this way
for (int ind = 0; ind <= 3; ind++)
{
    Console.WriteLine(names[ind]);
}

//Let's change one. Suppose we misspelled the third name. Should be Jasmine
names[2] = "Jasmine";
Console.WriteLine();
Console.WriteLine($"We corrected the spelling of {names[2]}");

// Let's change the first grade
grades[0] = 99;
Console.WriteLine($"The first grade is now {grades[0]}");



