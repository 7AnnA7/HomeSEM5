// Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = new int[10];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 999);
}

Console.WriteLine('[' + string.Join(", ", array) + ']');

for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 1)
    {
     sum = sum + array[j];
    } 
}
Console.WriteLine();
Console.Write($"Сумма элементов, стоящих на нечётных позициях, = {sum}");
