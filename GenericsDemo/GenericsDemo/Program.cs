using System;

using System.Collections.Generic;
using GenericsDemo;

namespace Genericarray

{
    public class program
    {
        static void Main(string[] args)

        {

            int[] intArray = { 1, 2, 3, 4 };

            double[] doubleArray = { 1.1, 1.2, 1.3, 1.4};

            char[] charArray = { 'A', 'N', 'I', 'L' };

            new GenericType<int>(intArray).Toprint();

            new GenericType<double>(doubleArray).Toprint();

            new GenericType<char>(charArray).Toprint();

        }
    }
}


