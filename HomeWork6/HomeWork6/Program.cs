Random random = new Random();
int fakeElementIndex = 15;
string weightChange = "abc";
int[] mainArray = new int[12];
int[] weights = new int[2] {-1, 1}; 
mainArray[random.Next(0, 11)] = weights[random.Next(0, 2)];
foreach (int elem in mainArray) { 
    Console.Write($"{elem}  ");
}
Console.WriteLine();

int[] subArray1 = new int[4] {mainArray[0], mainArray[1], mainArray[2], mainArray[3]}; 
int[] subArray2 = new int[4] { mainArray[4], mainArray[5], mainArray[6], mainArray[7]};
int[] subArray3 = new int[4] { mainArray[8], mainArray[9], mainArray[10], mainArray[11]};

int subArray1Summ = ArraySumm(subArray1);
int subArray2Summ = ArraySumm(subArray2);
int subArray3Summ = ArraySumm(subArray3);

int ArraySumm(int[] array) {
    int summ = 0;
    foreach (int elem in array) {
        summ += elem;
    }
    return summ;
}

if (subArray1Summ == subArray2Summ)
{
    if (mainArray[5] + mainArray[6] + mainArray[7] == mainArray[8] + mainArray[9] + mainArray[10]) 
    {
        fakeElementIndex = 12;
        if (mainArray[5] > mainArray[11]) 
        {
            weightChange = "меньше";
        }
        else
        {
            weightChange = "больше";
        }
    }
    else if (mainArray[5] + mainArray[6] + mainArray[7] > mainArray[8] + mainArray[9] + mainArray[10]) 
    {
        weightChange = "меньше";
        if (mainArray[9] > mainArray[10])
        {
            fakeElementIndex = 11;
        }
        else if (mainArray[9] < mainArray[10])
        {
            fakeElementIndex = 10;
        }
        else
        {
            fakeElementIndex = 9;
        }
    }
    else 
    {
        weightChange = "больше";
        if (mainArray[9] > mainArray[10])
        {
            fakeElementIndex = 10;
        }
        else if (mainArray[9] < mainArray[10])
        {
            fakeElementIndex = 11;
        }
        else
        {
            fakeElementIndex = 9;
        }
    }
}
else if (subArray1Summ > subArray2Summ)
{
    if (mainArray[0] + mainArray[1] + mainArray[4] == mainArray[2] + mainArray[3] + mainArray[8]) 
    {
        weightChange = "меньше";
        if (mainArray[5] > mainArray[6])
        {
            fakeElementIndex = 7;
        }
        else if (mainArray[5] < mainArray[6])
        {
            fakeElementIndex = 6;
        }
        else
        {
            fakeElementIndex = 8;
        }
    } 
    else if (mainArray[0] + mainArray[1] + mainArray[4] > mainArray[2] + mainArray[3] + mainArray[8])
    {
        weightChange = "больше";
        if (mainArray[0] > mainArray[1])
        {
            fakeElementIndex = 1;
        }
        else 
        {
            fakeElementIndex = 2;
        }
        
    }
    else if (mainArray[0] + mainArray[1] + mainArray[4] < mainArray[2] + mainArray[3] + mainArray[8])
    {
        if (mainArray[2] == mainArray[3])
        {
            fakeElementIndex = 5;
            weightChange = "меньше";
        }
        else if (mainArray[2] > mainArray[3])
        {
            weightChange = "больше";
            fakeElementIndex = 3;
        }
        else if (mainArray[2] < mainArray[3])
        {
            weightChange = "больше";
            fakeElementIndex = 4;
        }

    }
}
else if (subArray1Summ < subArray2Summ)
{
    if (mainArray[0] + mainArray[1] + mainArray[4] == mainArray[2] + mainArray[3] + mainArray[8])
    {
        weightChange = "больше";
        if (mainArray[5] > mainArray[6])
        {
            fakeElementIndex = 6;
        }
        else if (mainArray[5] < mainArray[6])
        {
            fakeElementIndex = 7;
        }
        else
        {
            fakeElementIndex = 8;
        }
    }
    else if (mainArray[0] + mainArray[1] + mainArray[4] < mainArray[2] + mainArray[3] + mainArray[8])
    {
        weightChange = "меньше";
        if (mainArray[0] < mainArray[1])
        {
            fakeElementIndex = 1;
        }
        else
        {
            fakeElementIndex = 2;
        }

    }
    else if (mainArray[0] + mainArray[1] + mainArray[4] > mainArray[2] + mainArray[3] + mainArray[8])
    {
        if (mainArray[2] == mainArray[3])
        {
            fakeElementIndex = 5;
            weightChange = "больше";
        }
        else if (mainArray[2] > mainArray[3])
        {
            weightChange = "меньше";
            fakeElementIndex = 4;
        }
        else if (mainArray[2] < mainArray[3])
        {
            weightChange = "меньше";
            fakeElementIndex = 3;
        }

    }
}
Console.WriteLine($"Фальшивка имеет номер {fakeElementIndex} и она {weightChange} оригинала");