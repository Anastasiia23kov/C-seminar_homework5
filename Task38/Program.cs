// Задача 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}

void ReleaseArray(int[] array)
{
    int max = array[0], min = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max) 
            max = array[i];

        if (array[i]<min) 
            min = array[i];
    }

    Console.WriteLine($"Максимальный элемент в массиве: {max}");
    Console.WriteLine($"Минимальный элемент в массиве: {min}");
    Console.WriteLine($"Разница между максимальным и манимальным элементами: {max-min}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; 

InputArray(array);
Console.WriteLine($"Начальный массив:[{string.Join(", ", array)}]");
ReleaseArray(array);
