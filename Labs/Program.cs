using System;

Console.WriteLine("Please enter a number:");
int enteredNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter {0} words:",enteredNumber);

string words = "";
for(int i = 0; i < enteredNumber; i++)
{
    Console.WriteLine("Word {0}:",i+1);
    string newWord = Console.ReadLine();
    if (newWord.Any(Char.IsWhiteSpace))
    {
        Console.WriteLine("Please do not enter space. Enter the word again.");
        i--;
        continue;
    }
    words += newWord;
}


int counter = 0;
char enteredChar = '?';
bool isChar = false;

do {
    Console.WriteLine("Please enter a character");
    char enteredContent = char.Parse(Console.ReadLine());

    if (Char.IsLetter(enteredContent)) {
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

int totalLength = words.Length;
int percentage = counter * 100 / totalLength;
if (percentage > 25)
{
    Console.WriteLine("The letter '{0}' appears {1} times in the array. This letter makes up more the 25% of the total number of characters,",enteredChar, counter);
}
else
{
    Console.WriteLine("The letter '{0}' appears {1} times in the array.",enteredChar,counter);
}

