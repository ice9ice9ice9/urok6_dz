/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

int M;
Console.WriteLine("Введите количество чисел массива M");
M = int.Parse(Console.ReadLine());

int[] array = new int[M];

Console.WriteLine("Заполните массив");

for (int i = 0; i < M; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

int count = 0;
for (int i = 0; i < M; i++)
{
    if (array[i] > 0)
        count++;
}

Console.WriteLine("Количество чисел больше 0: {0}", count);
    