using System;

namespace ЕНГ_Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Shuffle();
        }

        static void Shuffle()
        {
            int[] massiv = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var str = string.Join(" ", massiv);

            Console.WriteLine(str);

            Random random = new Random();
            for (int i = massiv.Length - 1; i >= 1; i--)
            {
                int randomIndex = random.Next(i + 1);
                int shuffleIndex = massiv[randomIndex];
                massiv[randomIndex] = massiv[i];
                massiv[i] = shuffleIndex;
                Console.WriteLine(massiv[i]);
            }
        }
    }
}
