/*The reason why there could be two famous person is that
first famouse person would let everyone else know him which 
makes other people can not fill the condition
that they can only know themselves.*/

using System;

bool[,] testArray = new bool[4, 4] { { true, true, true, false }, { false, true, true, false }, { false, false, true, false }, { false, false, true, true } };
Console.WriteLine(findFamousPerson(testArray));

int findFamousPerson(bool[,] relationArray)
{
    for(int i = 0; i < relationArray.GetLength(0); i++)
    {
        for(int j = 0; j < relationArray.GetLength(1); j++)
        {
            int knows = 0;
            bool breakLoops = false;
            if (relationArray[i, j] == true)
            {
                knows++;
                if (knows < 2)
                {
                    for(int k = 0; k < relationArray.GetLength(0); k++)
                    {
                        if (relationArray[k,j] == false)
                        {
                            breakLoops = true;
                            break;
                        }
                    }
                    if (breakLoops)
                    {
                        break;
                    }
                    return i;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
    return -1;
}