using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        // HOW TO OVERLOAD + (PLUS) OPERATOR
        public T[] array;
        private int count;
        public int capacity;
        public readonly object customList;

        public int Count
        {
            get
            {
                return count;
            }
        }

        // indexer
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public CustomList()
        {
            count = 0;
            capacity = 5;
            array = new T[capacity];
        }


        public void Add(T item)
        {
            // if statement - check to see if you have room to add
            if (count >= capacity)
            {
                capacity *= 2;
                T[] tempArray = new T[capacity];
                // fill in tempArray (loop over 'array' to fill 
                // original values into 'tempArray')
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = array[i];
                }
                tempArray[count] = item;
                array = tempArray;
            }
            else
            {
                // add to list (inner array)
                array[count] = item;
            }
            count++;
        }

        //public bool Remove()
        //{

        //}
    }
}
