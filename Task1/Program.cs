// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


        Console.Write("Введите количество чисел: ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[] Array = new int[m];

        void mas(int m)
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write($"{i + 1} число: ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

int amount(int[] Array)
        {
            int i = 0;
            int sum = 0;
            while (i < Array.Length)
            {
                if (Array[i] > 0)
                    sum = sum + 1;
                i = i + 1;
            }
            return sum;
        }

        mas(m);
        Console.Write($"Чисел больше нуля:-> [{ amount(Array)}]");
    