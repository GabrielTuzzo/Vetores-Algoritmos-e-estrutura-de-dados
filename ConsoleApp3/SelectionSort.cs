using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class MetodosAuxiliares
    {
        public static void Main(string[] args)
        {
            string[] array = { "banana", "laranja", "maçã", "uva" };
            Console.WriteLine("Array antes da ordenação:");
            PrintArray(array);

            array = SelectionSort.Sort(array);

            Console.WriteLine("\nArray após a ordenação:");
            PrintArray(array);
        }

        private static void PrintArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static bool Less(string a, string b)
        {
            return string.Compare(a, b) < 0;
        }

        public static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
    }
    public static class SelectionSort {
        public static string[] Sort(string[] vector)
        {
            if (vector != null || vector.Length > 1)
                for (int i = 0; i < vector.Length; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < vector.Length; j++) {
                        if (MetodosAuxiliares.Less(vector[j], vector[min]))
                        min = j;
                    }
                    MetodosAuxiliares.Swap(ref vector[min], ref vector[i]);
                }
            return vector;
        }
    }
}
