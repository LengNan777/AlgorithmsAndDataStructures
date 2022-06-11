using System;

int enteredNumber =0;
string words = "";
char enteredContent = ' ';
int counter = 0;
char enteredChar = '?';
bool isChar = false;
int percentage = 0;

GetNumberInput();
GetWordsInput();
CountCharacters(words, enteredContent);
GetCharacterOccurrencePercentage(words, counter);
PrintResults(percentage, enteredChar, counter);

int GetNumberInput()
{
    Console.WriteLine("Please enter a number:");
    enteredNumber = int.Parse(Console.ReadLine());
    return enteredNumber;
}

void GetWordsInput()
{
    Console.WriteLine("Please enter {0} words:", enteredNumber);

    for (int i = 0; i < enteredNumber; i++)
    {
        Console.WriteLine("Word {0}:", i + 1);
        string newWord = Console.ReadLine();
        if (newWord.Any(Char.IsWhiteSpace))
        {
            Console.WriteLine("Please do not enter space. Enter the word again.");
            i--;
            continue;
        }
        words += newWord;
    }
}

char getCharacterInput()
{
    Console.WriteLine("Please enter a character");
    return char.Parse(Console.ReadLine());
}

int CountCharacters(string words, char charToCount)
{
    do
    {
        enteredContent = getCharacterInput();

        if (Char.IsLetter(enteredContent))
        {
            isChar = true;
            enteredChar = enteredContent;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == enteredContent)
                {
                    counter++;
                }
            }
        }
    } while (!isChar);
    return counter;
}

int GetCharacterOccurrencePercentage(string words, int counter)
{
    percentage = counter * 100 / words.Length;
    return percentage;
}

void PrintResults(int percentage, char enteredChar, int counter)
{
    if (percentage > 25)
    {
        Console.WriteLine("The letter '{0}' appears {1} times in the array. This letter makes up more the 25% of the total number of characters,", enteredChar, counter);
    }
    else
    {
        Console.WriteLine("The letter '{0}' appears {1} times in the array.", enteredChar, counter);
    }

}