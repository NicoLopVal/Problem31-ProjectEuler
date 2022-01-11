
int[] coinValues = {1 , 2, 5, 10, 20, 50, 100, 200};

int[,] totalPossibilities = new int[8, coinValues.Max() + 1];

int numCombination = 0;
int counter = 1;
int targetValue = coinValues.Max();

for (int i = 0; i < coinValues.Length; i++)
{
    while (numCombination < targetValue)
    {
        numCombination = coinValues[i] * counter;
        totalPossibilities[i, counter - 1] = numCombination;
        totalPossibilities[i, counter] = 0;
        counter++;

    }
    counter = 1;
    numCombination = 0;
}

double totalCombinations = 0;
for (int i1p = 0; i1p < (targetValue / coinValues[0]) + 1; i1p++)
{
    for (int i2p = 0; i2p < (targetValue / coinValues[1]) + 1; i2p++)
    {
        for (int i5p = 0; i5p < (targetValue / coinValues[2]) + 1; i5p++)
        {
            for (int i10p = 0; i10p < (targetValue / coinValues[3]) + 1; i10p++)
            {
                for (int i20p = 0; i20p < (targetValue / coinValues[4]) + 1; i20p++)
                {
                    for (int i50p = 0; i50p < (targetValue / coinValues[5]) + 1; i50p++)
                    {
                        for (int i100p = 0; i100p < (targetValue / coinValues[6]) + 1; i100p++)
                        {
                            for (int i200p = 0; i200p < (targetValue / coinValues[7]) + 1; i200p++)
                            {
                                if (totalPossibilities[0, i1p] + totalPossibilities[1, i2p] + totalPossibilities[2, i5p]
                                    + totalPossibilities[3, i10p] + totalPossibilities[4, i20p] + totalPossibilities[5, i50p]
                                    + totalPossibilities[6, i100p] + totalPossibilities[7, i200p] == targetValue)
                                    totalCombinations++;
                            }
                        }
                    }
                }
            }
        }
    }
}
Console.WriteLine("There are {0} different ways can £2 be made using any number of coins", totalCombinations);