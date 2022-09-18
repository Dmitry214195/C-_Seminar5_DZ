//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.WriteLine("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);

Console.Write("Mассив: ");

PrintArray(numbers);

int[] result = null;


if (numbers.Length % 2 == 0)
{
    size = numbers.Length / 2;
    result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = numbers[i] * numbers[numbers.Length - i - 1];
    }
}
else
{
    size = (numbers.Length / 2) + 1;
    result = new int[size];

    for (int i = 0; i < size; i++)
    {
        if (i == (size - 1))
        {
            result[i] = numbers[i];
        }
        else
        {
            result[i] = numbers[i] * numbers[numbers.Length - i - 1];
        }
    }
}

for (int i = 0; i < size; i++)
{
    Console.Write(result[i] + ",");

}

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}