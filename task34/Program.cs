// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[12];
int countCH = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
for (int j = 0; j < array.Length; j++)
{
 if (array[j] % 2 == 0)
 {
  countCH = countCH + 1;
 }
}
Console.Write($"Количество чётных чисел из массива: {countCH}");