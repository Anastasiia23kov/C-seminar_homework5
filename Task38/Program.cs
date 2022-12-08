// Задача 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//void InputArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//        array[i] = new Random().Next(-100, 100);
//}

void InputArray(double[] array)
{
    Random rand = new Random();
    double min = -10;
    double max = 10;
    double range = max - min;
    for (int i = 0; i < array.Length; i++)
    {
        double sample = rand.NextDouble();
        double scaled = (sample*range) + min;
//        float f = (float)scaled;
        array[i] = (double)(float)scaled;
//        Console.WriteLine(f);
    }
}

void ReleaseArray(double[] array)
{
    double max = array[0], min = array[0];
    
    for (double i = 0; i < array.Length; i++)
    {
        if (array[(int)i]>max) 
            max = array[(int)i];

        if (array[(int)i]<min) 
            min = array[(int)i];
    }

    Console.WriteLine($"Максимальный элемент в массиве: {max}");
    Console.WriteLine($"Минимальный элемент в массиве: {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами: {max-min}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n]; 

InputArray(array);
Console.WriteLine($"Начальный массив:[{string.Join(", ", array)}]");
ReleaseArray(array);
