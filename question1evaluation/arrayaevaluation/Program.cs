using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayaevaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
             Array.Sort(arr);
            int min = arr[0];
            int max = arr[arr.Length - 1];


            Console.WriteLine(min);
            Console.WriteLine(max);

        }
    }
}
