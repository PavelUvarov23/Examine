﻿﻿string[] arr1 = new string[11] {"Hello", "2", "sun", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};
string[] arr2 = new string[arr1.Length];
void SecondArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}   
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
SecondArray(arr1, arr2);
PrintArray(arr2);