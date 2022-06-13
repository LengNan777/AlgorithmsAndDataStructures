using System;

//These codes just for convenience of test.
List<int> primeNumbers = new List<int> { 1, 2, 3 };
List<int> secondNumber = new List<int>(new int[] {4,5,6});
List<int> thirdNumber = new List<int> { 6 };
List<int> forthNumber = new List<int>(new int[] { 6, -2, 5, 3 });
List<List<int>> testList = new List<List<int>>();

testList.Add(primeNumbers);
testList.Add(secondNumber);
testList.Add(thirdNumber);

//Function 1: MaxNumbersInLists.
Console.WriteLine("Function 1 test: Entered list is {1,2,3} ,{4,5,6} and {6}.");
MaxNumbersInLists(testList);
Console.WriteLine();

//Function 2: HighestGrade.
Console.WriteLine("Function 2 test: Entered list is {1,2,3} ,{4,5,6} and {6}.");
Console.WriteLine(HighestGrade(testList));
Console.WriteLine();

//Function 3:OrderByLooping.
Console.WriteLine("Function 3 test: Entered list is { 6, -2, 5, 3 }.");
OrderByLooping(forthNumber);
Console.WriteLine();

int GetHighestValueInList(List<int> testList)
{
    int highestValue = testList[0] ;
    for (int i = 1; i < testList.Count; i++)
    {
        if (testList[i] > highestValue)
        {
            highestValue = testList[i] ;
        }
    }
    return highestValue;
}

List<int> MaxNumbersInLists(List<List<int>> testList)
{
    List<int> maxNumbers = new List<int>();

    for (int i = 0; i < testList.Count; i++)
    {
        maxNumbers.Add(GetHighestValueInList(testList[i]));
    }

    for(int i = 0; i < maxNumbers.Count; i++)
    {
        Console.Write("List {0} has a maximum of {1}. ", i +1 ,maxNumbers[i]);
    }
    
    Console.WriteLine();
    return maxNumbers;
}

String HighestGrade(List<List<int>> testList)
{
    List<int> maxIntList = MaxNumbersInLists(testList);
    int highestGrade = GetHighestValueInList(maxIntList);
    int[] classes = new int[testList.Count];
    int index = 0;

    for ( int i = 0; i < testList.Count; i++)
    {
        for(int j = 0; j< testList[i].Count; j++)
        {           
            if (testList[i][j] == highestGrade)
            {
                classes[index] = i + 1;
                index++;
            }
        }
    }

    string indexPart = $"{classes[0]}";
    
    if (classes.Length > 1)
    {
        for (int i = 1; i < index; i++)
        {
            indexPart += " and " + classes[i];
        }
    }

    string classSPart = index > 1?"classes":"class";
    string finalReturn = $"The highest grade is {highestGrade}.This grade was found in {classSPart} {indexPart}.";
    return finalReturn;
}

List<int> OrderByLooping(List<int> testList)
{
    int listLength = testList.Count;
    for(int i = 0; i < listLength; i++)
    {
        for (int j = 0; j < listLength - i - 1; j++)
        {
            if (testList[j] > testList[j + 1])
            {
                (testList[j], testList[j + 1]) = (testList[j + 1], testList[j]);
            }
        }
    }
    
    for(int i = 0; i < testList.Count; i++)
    {
        Console.Write("{0} ",testList[i]);
    }
    return testList;
}