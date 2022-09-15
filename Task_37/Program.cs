// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.


int J;
            Console.Write("Введите размерность массива");
            J = int.Parse(Console.ReadLine());
            double[] chisla = new double[J];
            int h;
            if (J % 2 == 0)
            {
                h = J / 2;
            }
            else
            {
                h = J / 2 + 1;
            }
            double[] resultat = new double[h];
            for (int i = 0; i < J; i++)
            {
                Console.Write("Введите " + (i + 1) + " элемент массива ");
                chisla[i] = double.Parse(Console.ReadLine());
            }
            double k = 0;
            for (int i = 0, j = 0; i < J; j++, i += 2)
            {
                k = (chisla[i] * chisla[i + 1]);
                resultat[j] = k;
                Console.WriteLine(resultat[j]);
            }
            for (var i = 1; i < J; i++)
{
    resultat[i - 1] = chisla[i - 1] * chisla[i];
    Console.WriteLine(resultat[i - 1]);
}
