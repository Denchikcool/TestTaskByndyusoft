using System;
using System.Linq;

namespace TestTaskByndyusoft
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 0, 3, 19, 492, -10, 1 };
            int result = SumOfTwoLessElements(arr);
            Console.WriteLine(result);
        }

        //Первая реализация
        public static int SumOfTwoLessElements(int[] array)
        {
            if(array == null || array.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements!");
            }

            Array.Sort(array);
            return array[0] + array[1];
        }

        //Вторая реализация через Linq
        public static int SumOfTwoMinNumbers(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements!");
            }

            int[] sortedArray = array.OrderBy(x => x).Take(2).ToArray();
            return sortedArray[0] + sortedArray[1];
        }
    }
}
