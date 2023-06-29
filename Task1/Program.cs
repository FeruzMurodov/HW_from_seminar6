/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] Array = new int[5];
for (int i = 0; i < 5; i++)
{
    Array[i] = new Random().Next(-100, 101);
}
Console.WriteLine(string.Join(",", Array));
int count = 0;
foreach (int el in Array)
{
    count += el>0 ? 1:0;
}
Console.WriteLine(count);