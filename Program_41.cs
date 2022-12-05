//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите количество чисел М: ");
int M = int.Parse(Console.ReadLine() ?? "");

int[] array = GetNumberToArray(M);
Console.Write(String.Join(" ", array));

int CountPositivNumbers = FindPositivNumbers(array);
Console.WriteLine($" -> {CountPositivNumbers}");

int[] GetNumberToArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size ; i++)
    {
     Console.Write($"Введите {i + 1}-ое число: ");
     res[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return res;
}

int FindPositivNumbers(int[] array)
{   
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) j++;
        
    }
    return j;
}

