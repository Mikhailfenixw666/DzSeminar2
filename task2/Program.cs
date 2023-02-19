// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.WriteLine("Введите чило: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = number1.ToString().Length;
if (number2 >= 3)
{
  while (number1 > 999)
  {
    number1 = number1 / 10;
  }
  int result = number1 % 10;
  Console.WriteLine("Третья Цифра " + result);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}