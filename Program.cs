// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа:
int Prompt(string msg)
{

System.Console.WriteLine("msg");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt ("Введите трехзначное число");
if (number >=100 && number <1000)
{
int mid = (number % 100 - number % 10) / 10;
System.Console.WriteLine("Вторая цифра числа {0} является {1}", number, mid);
}
else
System.Console.WriteLine("Это число не трехзначное");