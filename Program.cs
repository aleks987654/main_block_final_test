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
    if (array.Length == 0) 
    {
        Console.WriteLine("нет элементов, удовлетворяющих условию");
        return;
    }
    foreach (var e in array)
    {
        Console.Write($"'{e}' ");
    }
    Console.WriteLine();
}

// Функция поэтапного вывода операций с массивом
void Processing(string[] array, int ex_n)
{
    Console.WriteLine();
    Console.WriteLine($"ПРИМЕР {ex_n}");

    Console.WriteLine("Массив:");
    PrintArray(array);

    Console.WriteLine("Элементы массива, состоящие из 3 либо менее символов:");
    PrintArray(Array3SymbolsElements(array));
}

// ********** Тело программы **********

Processing(["Hello", "2", "world", ":-)"], 1);
Processing(["1234", "1567", "-2", "computer science"], 2);
Processing(["Russia", "Denmark", "Kazan"], 3);
