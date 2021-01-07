using System;

namespace Wejściena8k
{
    class Program
    {
        static void CircleField()
        {
            double r = 2.5;
            double result;

            result = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(result);

        }
        static void WorkDo()
        {
            int count = 0;
            do
            {
                Console.WriteLine($"The count value is {count}");
                count++;
            } while (count < 10);
        }
        static void Loop()
        {
            for (int counter = 2; counter < 50; counter += 2)
            {
                Console.WriteLine($"Hello. This counter value is {counter}");
            }
        }
        static void Counting()
        {
            int sum = 0;
            for (int i = 0; i <= 30; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
                Console.WriteLine($"The total sum is {sum}");
            }
        }
        static void CountList()
        {
            var names = new List<> { "Adam", "Tomasz", "Anna" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello. This is {name.ToUpper()}");
            }

            var fibbonaciNumbers = new List { 1, 1 };
            for (int i = 1; i <= 20; i++)
            {
                while (fibbonaciNumbers.Count < 20)
                {
                    var first = fibbonaciNumbers[fibbonaciNumbers.count - 1];
                    var second = fibbonaciNumbers[fibbonaciNumbers.count - 2];
                    fibbonaciNumbers.Add(first + second);
                }
                foreach (var num in fibbonaciNumbers)
                {
                    Console.WriteLine($"The sum in total is {num} ");
                }
            }
        }
        static void Main(string[] args)
        {
            CircleField();
            WorkDo();
            Loop();
            Counting();
            CountList();
            Console.ReadKey();
        }
    }
}
