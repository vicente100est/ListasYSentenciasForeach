﻿using System;
using System.Collections.Generic;

namespace ListCommonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                4,3,5,19
            };

            Show(numbers);

            numbers.Insert(0, 6);

            Show(numbers);

            if (numbers.Contains(19))
                Console.WriteLine("Existe");
            else
                Console.WriteLine("No existe");

            int pos = numbers.IndexOf(19);
            Console.WriteLine(pos);

            pos = numbers.IndexOf(100);
            Console.WriteLine(pos);

            numbers.Sort();
            Show(numbers);

            numbers.AddRange(new List<int>()
                {
                    200,300,25
                }
            );
        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("-- Numeros --");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
