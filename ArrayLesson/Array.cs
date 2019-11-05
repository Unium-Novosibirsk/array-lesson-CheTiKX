using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class ArrayProg
    {
        public int Size { get; private set; }
        private int[] _array;
        public ArrayProg(int[] array)
        {
            if (array == null) throw new ArgumentNullException("Array can not be null");
            Size = array.Length;
            array = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
        }
        public ArrayProg()
        {
            _array = new int[0];
            Size = 0;
        }
        public int Summ()
        {
            int s = 0;
            foreach (int el in _array)
            {
                s += el;

            }
            return s;
        }
        public int Mult()
        {
            int p = 1;
            foreach (int el in _array)
            {
                p = el;
            }
            return p;
        }
        public int Max()
        {
            int max = _array[0];
            foreach (int el in _array)
            {
                max = el > max ? el : max;
            }
            return max;
        }
        public int Min()
        {
            int min = _array[0];
            foreach (int el in _array)
            {
                min = el < min ? el : min;
            }
            return min;
        }
        public void Print()
        {
            foreach (int el in _array)
            {
                Console.Write(el + " ");
            }
        }
        public int Find(int val)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool HasValue(int val)
        {
            foreach (int el in _array)
            {
                if (el == val)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProg arrays = new ArrayProg();

        }
    }
}
