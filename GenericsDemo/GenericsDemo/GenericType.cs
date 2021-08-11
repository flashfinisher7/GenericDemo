using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class GenericType<T>
    {

            private T[] inputArray;

            public GenericType(T[] inputArray)

            {

                this.inputArray = inputArray;

            }

            public void Toprint()

            {

                foreach (var element in inputArray)

                {

                    Console.WriteLine(element);

                }

                Console.WriteLine("-------------------------------------");



            }

    }
}
