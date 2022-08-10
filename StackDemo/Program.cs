//This example demonstrates two data structures: Stacks and Queues
//Stacks operate as Last In First Out (LIFO) or First In Last Out (FILO)
Stack<string> cards = new Stack<string>();
// add to the stack
cards.Push("3D");
cards.Push("AS");
cards.Push("QH");
cards.Push("10D");

// pull the last one added. Removes that item from the stack
string next = cards.Pop();

Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

//If you pop when there is nothing left you will get a stack empty exception

Console.WriteLine();

//Queues operate as First In First Out (FIFO) or Last In Last Out (LILO)
Queue<int> nums = new Queue<int>();
nums.Enqueue(5); // 5 got there first 
nums.Enqueue(10);
nums.Enqueue(15);
nums.Enqueue(20);

Console.WriteLine(nums.Dequeue()); // First will go first
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue()); // First will go first
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue()); // First will go first
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue()); // First will go first
Console.WriteLine(nums.Count);

// Console.WriteLine(nums.Dequeue()); // This line will throw and exception since there is nothing left in the queue


//This will empty out a stack
cards.Clear();

//The following code will put 5D on the bottom, JH next, and 3S on top 
cards.Push("5D");
cards.Push("JH");
cards.Push("3S");

Console.WriteLine(cards.Pop()); // Expect 3S

//Look at the top of the deck but pull it off 
string top = cards.Peek();
Console.WriteLine($"The top is {top} but we did not remove it");

Console.WriteLine(cards.Pop()); // Expect JH

cards.Push("9H");
cards.Push("10D");
cards.Push("KS");

Console.WriteLine(cards.Pop());

cards.Push("5D");

//Now let's draw them all off
//Lets draw all the rest of the cards. 
while(cards.Count > 0)
{
    next = cards.Pop();
    Console.WriteLine($"We just drew {next}.");
}

Console.WriteLine($"The count of the deck is now {cards.Count}"); //Expect to see 0

Console.WriteLine();

// One more stack demo 
//Put 5 cards on and then draw them all off. 
cards.Clear();
cards.Push("AD");
cards.Push("2D");
cards.Push("3D");
cards.Push("4D");
cards.Push("5D");

while(cards.Count > 0)
{
    Console.WriteLine(cards.Pop());
}

Console.WriteLine();
//One more queue demo 
//Put 5 numbers in a queue, then go through the whole queue.

nums.Clear();    // Empty out the nums queue
nums.Enqueue(1);
nums.Enqueue(2);
nums.Enqueue(3);
nums.Enqueue(4);
nums.Enqueue(5);

while (nums.Count > 0)
{
    Console.WriteLine(nums.Dequeue());
}



