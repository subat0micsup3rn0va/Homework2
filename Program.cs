 //Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным:
 int Prompt(string msg)
{

System.Console.WriteLine("msg");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string ss = "Не день недели";
string check(int number)
{
if (number >= 6 && number < 8) ss = "Выходной";
if (number >= 1 && number < 7) ss = "Будний день";
return ss;
}
System.Console.WriteLine(check(number));