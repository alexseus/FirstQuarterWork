/*
Написать программу, которая из имеющегося массива строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] CreateStringArray(int arrayLenght)
{
    string[] stringArray = new string[arrayLenght];
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"Введите {i} строку массива: ");
        stringArray[i] = Console.ReadLine()!;
    }
    return stringArray;
}

void ShowFilteredArray(string[] array, int filterLenght)
{
    Console.Write($"Строки в массиве длиной <= {filterLenght} символов: [");
    int comma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= filterLenght)
        {
            if (comma == 1 && i < array.Length) Console.Write(", ");
            Console.Write($"\"{array[i]}\"");
            comma = 1;
        }

    }
    Console.Write("]");
}


string[] srtingArray = CreateStringArray(5);    // формируем запрос массива строк, указывая размер массива
ShowFilteredArray(srtingArray, 3);              // выводим используя фильтр-длину строки