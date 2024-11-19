namespace ConsoleApp21
{
    using System;

    class Program
    {
        // Універсальний метод для пошуку максимального елемента
        static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Масив не може бути порожнім");

            T max = array[0];
            foreach (var item in array)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        // Універсальний метод для пошуку мінімального елемента
        static T FindMin<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Масив не може бути порожнім");

            T min = array[0];
            foreach (var item in array)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            // Масив цілих чисел
            int[] intArray = { 1, 3, 5, 7, 2, 8 };
            Console.WriteLine($"Макс. у масиві цілих чисел: {FindMax(intArray)}");
            Console.WriteLine($"Мін. у масиві цілих чисел: {FindMin(intArray)}");

            // Масив дійсних чисел
            double[] doubleArray = { 1.1, 3.3, 5.5, 7.7, 2.2, 8.8 };
            Console.WriteLine($"Макс. у масиві дійсних чисел: {FindMax(doubleArray)}");
            Console.WriteLine($"Мін. у масиві дійсних чисел: {FindMin(doubleArray)}");
        }
    }

}
