﻿// Задача: 
// Написать программу, которая из имеющегося массива строк,
// формирует массив из строк, 
// длина которого меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Denmark", "Kazan"] -> []


// string[] array = { "hello", "2", "world", ":-)" };
// string[] array = { "1234", "1567", "-2", "computer science" };
string[] array = { "Russia", "Denmark", "Kazan" }; 

string[] ArrayTrimmedStrings(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}
string[] receivedArray = array;
string[] shortArray = ArrayTrimmedStrings(arr);
Console.WriteLine("[{0}] -> [{1}]", string.Join(", ", receivedArray), string.Join(", ", shortArray));


