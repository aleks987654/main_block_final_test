// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;
using System.Text;

// Функция получения массива элементов, 
// состоящих из трёх либо менее символов
string[] Array3SymbolsElements(string[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) n++;
    }

    string[] sym3els = new string[n];
    n = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            sym3els[n] = array[i];
            n++;
        }
    }
    
    return sym3els;
}

// Функция вывода элементов массива на консоль
void PrintArray(string[] array)
{
    foreach (var e in array)
    {
        Console.Write($"'{e}' ");
    }
    Console.WriteLine();
}


// string[] str_array = ["Hello", "2", "world", ":-)"];
Console.WriteLine("Исходный массив:");
PrintArray(["Hello", "2", "world", ":-)"]);

string[] res = Array3SymbolsElements(["Hello", "2", "world", ":-)"]);
Console.WriteLine("Массив элементов, состоящих из 3 либо менее символов:");
PrintArray(res);

