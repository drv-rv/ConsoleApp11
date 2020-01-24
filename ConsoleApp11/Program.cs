using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 39, 2, 9, 4, 555, 87, 5, 8 };

            int max = int.MinValue;
            int index = 0;
            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {

                    max = a[i];
                    index = i;
                }

                if (a[i] < min)
                {

                    min = a[i];

                }
            }
            Console.WriteLine(index);
            Console.WriteLine(min);
        }
    }
}
