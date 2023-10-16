/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
    
Console.WriteLine("Введите число:");        
int a = Convert.ToInt32(Console.ReadLine()!);

int summa(int number)
{
    string TmpStr;
    TmpStr = Convert.ToString(number);
    Console.WriteLine(TmpStr);
    int sum =0;
    for(int i = 0; i < TmpStr.Length; i++)
    {
       sum = sum + Convert.ToInt32(TmpStr[i]);
    }
    return sum;
}
Console.WriteLine("Сумма всех цифр:");  
Console.WriteLine(summa(a));
