﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLesson
{
    public class Array
    {
        private int[] _array;
        public int Length { get; private set; }
        public Array()
        {
            Length = 0;
            _array = new int[0];
        }
        public Array(int [] array)
        {
            Length = array.Length;
            _array = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                _array[i] = array[i];
        }
        public int GetElementByIndex(int index)
        {
        
            if (index < 0 || index >= _array.Length)
                throw new IndexOutOfRangeException();

            return _array[index];

        }
        public int SetIndex(int index)
        {
            if (index < 0 || index >= _array.Length)
                throw new IndexOutOfRangeException();
            else
            {
                Console.WriteLine("Введите замену");
                int a = int.Parse(Console.ReadLine());
                return a;
            }
        }
      
        public int multiplay()
        {
            int p = 1;
            foreach (int element in _array) ;
            p=p*p;
            return p;
        }
        public int this[int index]
        {
            set
            {
                _array[index] = value;
            }

            get
            {
                return _array[index];
            }

        }
        public int delete(int index)
        {
            if (index < 0 || index >= _array.Length)
                throw new IndexOutOfRangeException();
            else
            {
                Console.WriteLine("Введите индекс");
                int a = int.Parse(Console.ReadLine());
                return 0;
            }
        }
    }


}

