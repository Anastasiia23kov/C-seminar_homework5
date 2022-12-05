// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}

void ReleaseArray(int[] array)
{
    int sumNechet = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        sumNechet += array[i];
    }
    Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях: {sumNechet}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; 

InputArray(array);
Console.WriteLine($"Начальный массив:[{string.Join(", ", array)}]");
ReleaseArray(array);
