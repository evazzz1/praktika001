// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.
//массив [1.22 4.5 3.33] => 3.28

double [] myArray = new double [10];
int a; int b;        

for(int i = 0; i < myArray.Length; i++)
{
    a = new Random().Next(0,101); //целая часть
    b = new Random().Next(1,100); //число после запятой
    myArray[i] = b * 0.01 + a;
}

double min = myArray[0]; 
double max = myArray[0];

for(int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + "  ");
    if(min > myArray[i])
    {
        min = myArray[i];
    }
    if(max < myArray[i])
    {
        max = myArray[i];
    }
}
Console.WriteLine();
Console.WriteLine("MIN " + min + " MAX " + max + " Разница: " + (max-min));