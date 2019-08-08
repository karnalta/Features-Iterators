using System;

namespace Features_Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 6, 8, 2, 9, 4, 3, 8, 6, 2, 7, 9, 2, 1, 5, 3, 2, 5, 4, 8, 9, 2, 1 };
            var myEnumerable = new MyEnumerable(numbers);

            Console.WriteLine("MyEnumerator class enumerator :");
            foreach (int i in myEnumerable)
                Console.Write($"{i} ");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("MyEnumerable self-implemented enumerator :");
            foreach (int i in myEnumerable.GetMultipliedEnumerator(3))
                Console.Write($"{i} ");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("MyEnumerable self-implemented enumerator :");
            foreach (int i in myEnumerable.GetInfiniteEnumerator(200))
                Console.Write($"{i} ");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
