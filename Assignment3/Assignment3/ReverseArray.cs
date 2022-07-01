using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class ReverseArray
    {
        public static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10);
            Reverse(numbers);
            PrintNumbers(numbers);
        }
        public static int[] GenerateNumbers(int x)
        {
            int[] numbers = new int[x];
            for (int i = 0; i < x; i++)
            {
                numbers[i] = i + 1;
            }
            return numbers;
        }
        public static void Reverse(int[] arr)
        {
            foreach (int k in arr)
            {
                Console.Write($"{k} ");
            }
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                int temp;
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
        public static void PrintNumbers(int[] arr)
        {
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
