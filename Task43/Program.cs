// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4, -> (-0,5; -0,5)

int[] InputArray(string message, int size)
{
    Console.Write(message);
    int[] inputArr = Array.ConvertAll(Console.ReadLine()!.Split(" ", size), int.Parse); // массив через пробел  ! - убрать предупреждение о null
    return inputArr;
}

void PrintArray(double[] arrayToOutput)
{
    System.Console.WriteLine("(" + string.Join("; ", arrayToOutput) + ")");
}

double CoordX(double k1, double b1, double k2, double b2)
{
    double x;
    x = (b2 - b1) / (k1 - k2);
    return x;
}

double CoordY(double k1, double x, double b1)
{
    double y;
    y = k1 * x + b1;
    return y;
}

///=========================================
double[] dotCoord = new double[2];
int[] equation1 = InputArray("Введите коэфициенты k1 b1 для первого уравнения: ", 2);
int[] equation2 = InputArray("Введите коэфициенты k2 b2 для второго уравнения: ", 2);

System.Console.WriteLine($"Уравнение первой прямой:  y = {equation1[0]} * x + {equation1[1]} ");
System.Console.WriteLine($"Уравнение второй прямой:  y = {equation2[0]} * x + {equation2[1]} ");

if (equation1[0] != equation2[0])
{
    dotCoord[0] = CoordX(equation1[0], equation1[1], equation2[0], equation2[1]);
    dotCoord[1] = CoordY(equation1[0], dotCoord[0], equation1[1]);
    System.Console.Write("Точка пересечения прямых ");
    PrintArray(dotCoord);
}
else
{
    System.Console.WriteLine(" Прямые паралельны ");
}
