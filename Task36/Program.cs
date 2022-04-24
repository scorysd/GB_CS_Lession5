// // Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях
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
        mass[i] = new Random().Next(-1000, 1000);
    }
}
FillMass();
PrintMass(mass);
int sum= 0;
for (int i = 1; i < mass.Length; i = i + 2)
{
    sum = sum + mass[i];
}
Console.WriteLine($"Сумма нечетных элементов массиваа равна: {sum}");