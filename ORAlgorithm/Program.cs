string ORfunction(string input)
{
    if (input.Length == 0)
    {
        return "";
    }
    
    string reversedInputString = ReverseString(input);
    char earliestLetter = GetEarliestCharacter(input);

    int vowelCount = CountVowels(input);
    
    string lastWord = vowelCount % 2 == 0 ? "rent" : "open";
    Console.WriteLine($"{reversedInputString}{earliestLetter}{lastWord}");
    return $"{reversedInputString}{earliestLetter}{lastWord}";
}

/// <summary>
/// Return the input string reversed.
/// </summary>
string ReverseString(string input)
{
    return new string(input.Reverse().ToArray());
}

/// <summary>
/// Returns the ealiest character in the string
/// Comparison is case-insensitive.
/// </summary>
char GetEarliestCharacter(string input)
{
    return input.ToLowerInvariant().Min();
}

/// <summary>
/// Counts case-insensitive vowels
/// </summary>
int CountVowels(string input)
{
    const string vowels = "aeiou";
    return input.Count(character => vowels.Contains(char.ToLowerInvariant(character)));
}


ORfunction("nepo");