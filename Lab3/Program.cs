using System;

Console.WriteLine("Please enter a word: ");
Console.WriteLine(isPalindrome(Console.ReadLine()));
Console.WriteLine("Please enter a few words to check the deplicate letters: ");
Console.WriteLine(DuplicateCharacters(Console.ReadLine()));
Console.WriteLine("Please enter a few words to check the unique words: ");
UniqueWords(Console.ReadLine());

bool isPalindrome(string testString)
{
    if (testString.Any(Char.IsWhiteSpace))
    {
        Console.WriteLine("Please do not enter any space! Please enter again.");
        isPalindrome(Console.ReadLine());
    }else
    {
        string lowerCaseString = testString.ToLower();
        int strLength = testString.Length;
        if (strLength % 2 == 0)
        {
            for (int i = 0; i < strLength / 2; i++)
            {
                if (lowerCaseString[i] == lowerCaseString[strLength - i - 1])
                {
                    continue;
                }
                return false;
            }
            return true;
        }
        else
        {
            for (int i = 0; i < (testString.Length - 1) / 2; i++)
            {
                if (lowerCaseString[i] == lowerCaseString[strLength - i - 1])
                {
                    continue;
                }
                return false;
            }
            return true;
        }
    }
    return true;
}

char[] DuplicateCharacters(string testString)
{
    string noSpaceString = testString.ToLower().Replace(" ", "");
    char[] chars = new char[noSpaceString.Length];
    char[] duplicateChars = new char[noSpaceString.Length];
    int charIndex = 0;

    for(int i = 0; i < noSpaceString.Length; i++)
    {   
        if (chars.Contains(noSpaceString[i]) && !duplicateChars.Contains(noSpaceString[i])){
            duplicateChars[charIndex] = noSpaceString[i];
            charIndex++;
        }else
        {
            chars[i] = noSpaceString[i];
        }
    }

    return duplicateChars;
}

String[] UniqueWords(string testString)
{
    String[] words = testString.ToLower().Split(' ');
    String[] uniqueWords = new String[words.Length];
    int uniqueWordsIndex = 0;

    for(int i = 0; i < words.Length; i++)
    {
        if (!uniqueWords.Contains(words[i]))
        {
            uniqueWords[uniqueWordsIndex] = words[i];
            uniqueWordsIndex++;
        }
    }

    for(int i = 0; i <= uniqueWordsIndex; i++)
    {
        Console.Write("{0} ",uniqueWords[i]);
    }

    return uniqueWords;
}