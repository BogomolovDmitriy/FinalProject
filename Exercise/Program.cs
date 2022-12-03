﻿string[] arrayA = {"Hello!", "2", "World", ":-)"};

Console.WriteLine("Массив до изменений: ");
PrintArray(arrayA);
Console.WriteLine();
Console.WriteLine("Массив после изменений: ");
PrintArray(GetArrayItemLengthMoreThanThree(arrayA));
Console.WriteLine();

string[] GetArrayItemLengthMoreThanThree(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count ++;
        }
    }
    string[] tempArray = new string[count]; 
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            tempArray[j] = array[i];
            j ++;
        }
    }
    return tempArray;  
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}
