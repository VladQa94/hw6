/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите колличество чисел, которые хотите задать: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
    for (int i = 0; i < size; i++) 
    {
        array[i] = Int32.Parse(Console.ReadLine());
    }

int numbersGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    } return count;
}

int NumbersGreaterZero = numbersGreaterZero(array);
Console.WriteLine($"Количество чисел больше 0 = {NumbersGreaterZero}");