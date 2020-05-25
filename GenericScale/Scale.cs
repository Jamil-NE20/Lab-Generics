using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericScale
{
    public class Scale <T> //class as the Type parameter
        where T : IComparable<T>  //generic CompareTo with the T
    {

        private T left;
        private T right;


        public Scale ( T left, T right)

        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier()
        {
            var comparison = left.CompareTo(right);

            if (comparison > 0) // if (this.left.CompareTo(this.right) > 0)
            {
                return left;
            }
            else if (comparison < 0) // if (this.left.CompareTo(this.right) < 0)
            {
                return right;
            }
            else
                return default(T);
        }

   

    }
}
