﻿// Написать программу, которая из имеющегося массива из строк,
// длина которых меньше либо равна 3 символа.
// Первоночальный массив можно ввесте с клавиатуры, либо задать на старте выполнения алгоритма

Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
int len = 3;
int pos = 0;

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());

 if (element.Length <= len)
    {
        arrayStrings[pos] = element;
        pos++;
    }
}

Console.WriteLine();
PrintArray(arrayStrings);

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + " ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine(" ]");
}
