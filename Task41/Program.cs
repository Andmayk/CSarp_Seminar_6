// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputArray()
{
    Console.Write("Введите числа через пробел: ");
    int[] inputArr = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse); // массив через пробел  ! - убрать предупреждение о null
    return inputArr;
}

void PrintArray(int[] arrayToOutput)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayToOutput) + "]");
}

int CountPositivNumber(int[] arrayToCount)
{
    int countPositivNumber = 0;
    for (int i = 0; i < arrayToCount.Length; i++)
    {
        if (arrayToCount[i] > 0) countPositivNumber++;
    }
    return countPositivNumber;
}
///==================
int[] array = InputArray();
PrintArray(array);
System.Console.WriteLine("Количество чисел больше 0 ->" + CountPositivNumber(array));
