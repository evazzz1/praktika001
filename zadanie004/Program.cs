//Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
//Размер массива должен быть равен количеству цифр.
//425 => [4 2 5]
//8741 => [8 7 4 1]
//4 => [4]

int number = new Random().Next(1,100001);
int num = number;
Console.WriteLine(num);
int countOfNumbers = 0;
for(int i = 0; i < 6; i++)
{
    if(num > 0)
    {
        countOfNumbers++;
    }
    num /= 10;
}
Console.WriteLine(countOfNumbers);
int [] myArray = new int [countOfNumbers];

for(int i = myArray.Length-1; i >= 0; i--)
{
    myArray[i] = number%10;
    number /= 10; 
}

foreach (int element in myArray)
{
    Console.Write(element + " ");
}