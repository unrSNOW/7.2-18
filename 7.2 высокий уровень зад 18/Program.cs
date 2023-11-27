try
{
    Console.WriteLine("введите предложение:");
    string input = Console.ReadLine();
    string[] words = input.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
    int shortest = int.MaxValue;
    foreach (string word in words)
    {
        if (word.Length < shortest)
        {
            shortest = word.Length;
        }
    }
    if (shortest == int.MaxValue)
    {
        Console.WriteLine("в предложении нет слов");

    }
    else
    {
        Console.WriteLine($"Длина самого короткого слова:{shortest}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
