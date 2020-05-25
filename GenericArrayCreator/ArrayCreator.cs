using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create <T> (int length, T item) // Declare the generic class
        {
            var array = new T[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = item;
            }

            return array; //return an array with the given length 


        }
    }
}
