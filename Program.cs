/*
Задача.
Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на 
старте выполнения алгортима. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

//функция получения массива элементы которых не более 3-х символов.
string[] GetArray(string[] initArray)
{
    string[] array = new string[0];
    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i].Length <= 3)
        {
            array = array.Append(initArray[i]).ToArray();
        }
    }
    return array;
}

//функция печати массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

//функция ввода элементов массива с консоли
string[] InitArray()
{
    string inputText = string.Empty;
    string[] array = new string[0];
    while (inputText != "end")
    {
        Console.WriteLine("Введите элемент, если закончили ввод - введите end");
        inputText = Console.ReadLine();
        if (inputText != "end")
        {
            array = array.Append(inputText).ToArray();
        }
    }
    return array;
}

string[] initArray = InitArray();
Console.WriteLine("Исходный массив:");
PrintArray(initArray);
string[] array = GetArray(initArray);
Console.WriteLine();
Console.WriteLine("Массив где в элементах не более 3 символов:");
PrintArray(array);
Console.WriteLine();
