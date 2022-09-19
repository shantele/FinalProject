// Задача: Написать программу, которая из 
// имеющегося массива строк формирует новый
// массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный 
// массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. 

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] initialArray = { "Hello", "2", "world", ":-)" };
Console.WriteLine(String.Join(", ", initialArray));

string[] shortArray = new string[initialArray.Length];
int shortSize = 0;
foreach (string element in initialArray)
{
    if (element.Length <= 3)
    {
        shortArray[shortSize] = element;
        shortSize++;
    }
}

Console.WriteLine(String.Join(", ", shortArray, 0, shortSize));