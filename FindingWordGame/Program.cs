Random random = new Random();
bool IsGme = false;
while (!IsGme)
{

    Console.Clear();
    Console.Write("Player 1, input your name: ");
    string user_1 = Console.ReadLine()!;
    Console.Write("Player 2, input your name: ");
    string user_2 = Console.ReadLine()!;

    Console.Write($"{user_1} please enter your word: ");
    string[] input = Console.ReadLine()!.Split();
    string guess = input[random.Next(input.Length)];
    int length = guess.Length;
    Console.Clear();

    Console.WriteLine($"{user_2} game is started");
    Console.WriteLine($"The length of the word is {length}");
    bool isGame = false;
    int attempt = 0;
    char[] word = new char[length];

    for (int i = 0; i < length; i++)
    {
        word[i] = '*';
    }

    while (!isGame)
    {
        Console.WriteLine();
        Console.Write("Please enter a letter: ");
        char letter = Console.ReadLine()![0];

        for (int i = 0; i < length; i++)
        {
            if (guess[i] == letter)
            {
                attempt++;

                word[i] = guess[i];
            }
        }

        Console.WriteLine(word);

        if (attempt == length)
        {
            isGame = true;
        }
    }

    Console.WriteLine($"\nCongratulations! {user_2} guessed the word: {guess}");
    Console.Write("Would you like to play again (y/n): ");
    char res = Console.ReadLine()![0];
    if (res == 'y')
    {
        continue;
    }
    else
    {
        IsGme = true;
    }
}