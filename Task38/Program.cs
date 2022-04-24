// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
Console.Clear();
Console.WriteLine("Введите количество элментов массива: ");
int[] mass = new int[Convert.ToInt32(Console.ReadLine())];
Console.Clear();
void PrintMass(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FillMass()
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-500, 1000);
    }
}
FillMass();
PrintMass(mass);
int FindMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
int FindMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
int max = FindMax(mass);
int min = FindMin(mass);
Console.WriteLine($"Максималльный элемент в массиве: " + max);
Console.WriteLine($"Минимальный элемент в массиве: " + min);
Console.WriteLine($"Разница между максимальным элементом и минимальным масссива равна: {max - Math.Abs(min)}");