// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше или равна 3 символам.


void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = InputString($"Введите строку {i + 1} массива: ");
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

void ResultArrayCreate(string[] array, string[] resultarray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultarray[count] = array[i];
            count++;
        }
    }
}
int arraylength = InputInt("Введите количество элементов в исходном массиве");

string[] array = new string[arraylength];
FillArray(array);
PrintArray(array);
Console.WriteLine();

string[] resultarray = new string[arraylength];

ResultArrayCreate(array, resultarray);

Console.WriteLine("Итоговый массив, в котором длина строки меньше или равна 3 символам");
PrintArray(resultarray);