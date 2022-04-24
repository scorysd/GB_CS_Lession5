// // Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
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
        mass[i] = new Random().Next(0, 301);
    }
}
FillMass();
PrintMass(mass);
int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"В указанном массиве {count} четных элементов(а)");