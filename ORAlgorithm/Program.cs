using System.Linq;

string ORfunction(string input)
{
    if (input.Length == 0)
    {
        return "";
    }
    
    List<char> reversedInput = new List<char>(input.Reverse());
    string reversedInputString = String.Concat(reversedInput);
    
    List<char> ordered = input.OrderBy(x => x).ToList();
    string orderedString = string.Join("", ordered);
    string earliestLetter = orderedString[0].ToString();
    
    int countOfVowels = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == 'a' ||
            input[i] == 'e' ||
            input[i] == 'i' ||
            input[i] == 'o' ||
            input[i] == 'u')
        {
            countOfVowels++;
        }
    }
    
    string lastWord = countOfVowels % 2 == 0 ? "rent" : "open";

    return $"{reversedInputString}{earliestLetter}{lastWord}";
}

ORfunction("nepo");