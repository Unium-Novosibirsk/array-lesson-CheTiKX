using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLesson
{
    class Program
    {
        static void Main(string[] args)
        {
   
                Console.Write("Введите элементы ");
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            try { 
                Array array = new Array(arr);
                Console.Write("Введите индекс ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(array.GetElementByIndex(a));
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("так не робит");
            }
            try
            {
                Array ar = new Array(arr);
                Console.WriteLine("Введите индекс");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(ar.SetIndex(b));
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("так не робит");
            }


            Console.ReadKey();
        }
    }
}
