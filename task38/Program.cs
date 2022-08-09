//Задайте с клавиатуры массив вещественных (double) чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//Задать размер (int) массива с клавиатуры
//[3 7 22 2 78] -> 76

Console.Write("Введите количество элементов в массиве: ");
int Elements = Convert.ToInt32(Console.ReadLine());
double[] myArray = new double[Elements];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите один из элементов массива с индексом {i}: ");
    myArray[i] = Convert.ToDouble(Console.ReadLine());
}

Console.Write('[' + string.Join("; ", myArray) + ']');
double max = myArray[0];
double min = myArray[0];

 for (int i=0; i < myArray.Length; i++)
 {
  if (myArray[i] > max) max = myArray[i];
  if (myArray[i] < min) min = myArray[i];
 }
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементоммассива = {max - min}");
