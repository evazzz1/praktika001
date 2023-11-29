// Задача 1: Задайте одномерный массив из 10 целых
//чисел от 1 до 100. Найдите количество элементов
//массива, значения которых лежат в отрезке [20,90].
// массив [10 21 14 93 23] => 2

int [] myArray = new int [10];
int result = 0;
for(int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(0,101);
}
foreach(int element in myArray)
{
    Console.Write(element + " ");
    if (element >= 20 && element <= 90)
    {
        result++;
    }
}
Console.WriteLine();
Console.WriteLine("Количесивтво элементов, соотвествующих условию: " + result);