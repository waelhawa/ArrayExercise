using System;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = {1.0, 5.2, 2.4, 6.7, 1.6, 0.5, 7.6, 0.3, -0.5};
            
            foreach (double i in nums)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Smallest value is: {FindSmallest(nums)}");
            string[] movieList = FillArray();
            foreach (string entry in movieList)
            {
                Console.WriteLine(entry);
            }
        }

        public static double FindSmallest(double [] array)
        {
            double num = array[0];
            foreach (double item in array)
            {
                if (item < num)
                {
                    num = item;
                }
            }
            return num;
        }

        public static string [] FillArray ()
        {
            int arrayItems;
            arrayItems = NumberEntry("How many movies do you have in mind? ");
            string[] movieList = new string[arrayItems];
            for (int i = 0; i < arrayItems; i++)
            {
                movieList[i] = MovieNameEntry(i);
            }
            return movieList;
        }

        public static int NumberEntry(string phrase)
        {
            string text;
            int number;
            while (true)
            {
                Console.Write(phrase);
                text = Console.ReadLine().Trim().ToLower();
                if (int.TryParse(text, out number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Ivalid entry.");
                }
            }
        } //end numberEntry

        public static string MovieNameEntry (int index)
        {
            string text;
            Console.Write($"Enter movie {index + 1}: ");
            text = Console.ReadLine();
            return text;
        }

    }
}
