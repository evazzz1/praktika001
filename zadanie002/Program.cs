// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
//которая определяет количество чётных чисел в массиве.
//массив [6 7 19 34 3 1 4 7 9 1] => 3 

int [] myArray = new int [10];
int result = 0;
for(int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(0,101);
}
foreach(int element in myArray)
{
    Console.Write(element + " ");
    if (element % 2 ==0)
    {
        result++;
    }
}
Console.WriteLine();
Console.WriteLine("Количесивтво элементов, соотвествующих условию: " + result);
