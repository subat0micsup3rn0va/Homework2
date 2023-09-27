// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет:
int Prompt(string msg)
{

System.Console.WriteLine("msg");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
int fnumber(int number)
{
while (number > 999)
{
number /= 10;
}
return number % 10;
}

bool check(int number)
{
if (number < 100)
return false;
else return true;
}

if (check(number) != true)
System.Console.WriteLine("Третьей цифры нет");
else
System.Console.WriteLine("Третья цифра числа {0} является {1}", number, fnumber(number));