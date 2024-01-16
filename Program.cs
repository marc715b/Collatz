/*
    The Collatz conjecture is a sequence defined for positive integers as follows:
        * If the current term is even, the next term is half of the current term.
        * If the current term is odd, the next term is 3 times the current term plus 1.
        * The sequence stops when it reaches 1.

    Write a program that takes a positive integer as input from the user and prints the Collatz sequence for
    that number. Additionally, count the number of steps it takes for the sequence to reach 1. The program
    should keep asking for input until the user enters 0.
*/

int count = 0;

int Collatz(int term) {
    // Increase the count by 1 each term.
    count++;

    // If the current term is 1, return. Otherwise, find the next term.
    if (term == 1) {
        Console.Write("1.\n");
        return term;
    } else {
        Console.Write($"{term} => ");

        int nextTerm;
        if (term % 2 == 0) 
            nextTerm = term / 2;
        else
            nextTerm = term * 3 + 1;

        return Collatz(nextTerm);
    }
}

// Keep checking and handling input until input reaches 0.
int input;
while ((input = Convert.ToInt32(Console.ReadLine())) != 0) {
    count = 0;
    Collatz(input);

    Console.WriteLine($"Finished Collatz conjecture for {input} in {count} terms.");
}