/* Доп.Задача Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. 
(Решить можно, если хотите потренироваться)
(Следующее число складывается из двух предыдущих)

Если N = 5 -> 0 1 1 2 3

Если N = 3 -> 0 1 1

Если N = 7 -> 0 1 1 2 3 5 8 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num == 0 || num == 1)
{
    Console.WriteLine("Не допустимое число");
}
else
{
    int[] Array = new int[num];
    Array[0] = 0;
    Array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        Array[i] = Array[i - 2] + Array[i - 1];
    }
    Console.WriteLine(string.Join(", ", Array));
}