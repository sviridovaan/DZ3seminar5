//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

Console.WriteLine("Введите число элементов массива");
double [] array = new double [Convert.ToInt32(Console.ReadLine())];
Random rnd = new Random();

int i = 0;
for (i = 0; i < array.Length; i ++)
{
    array [i] = rnd.Next(0, 100000) + Math.Round(rnd.NextDouble (), 2);
}
Console.WriteLine($"Заданный массив: "+ '[' + string.Join(", ", array) + ']');

double max = array[0];
double min = array[0];
for (int a = 0; a < array.Length; a++)
{
    if (array[a] > max)
    {
        max = array[a];
    }
    if (array[a] < min)
    {
        min = array[a];
    }
}
double result = max-min;
Console.WriteLine("Разница между максимальным элементом " + max + " и минимальным элементом "+ min + " массива равна "+ result);