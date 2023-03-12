// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше или равна 3 символам.


void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = InputString($"Введите строку {i+1} массива: ");
    }
}

int InputInt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

string InputString(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToString(Console.ReadLine());
}


void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
}

int arraylength = InputInt("Введите количество элементов в массиве");

string[] array = new string[arraylength];
FillArray(array);
PrintArray(array);
