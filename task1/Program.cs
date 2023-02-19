// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
System.Console.WriteLine("Введите трех значное число: ");
int right = Convert.ToInt32(Console.ReadLine());
int left = right.ToString().Length;
if (left == 3) {
	int result = ( right/10 ) % 10;
	Console.WriteLine("Вторая цифра " + result);
} else {
	Console.WriteLine("Ошибка!!! Введите трехзначное число!!!");
}