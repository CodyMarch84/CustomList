using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        // HOW TO OVERLOAD + (PLUS) OPERATOR
        public T[] array;
        private int count;
        public int capacity;
        public readonly object customList;
        public T[] item;
        public int tempCount;

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

        public bool Remove(T item)
        {
            bool removeItem = false;
            T[] outcome = new T[capacity];
            tempCount = 0;

            // for loop
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item) && !removeItem)
                {
                    count--;
                    outcome[i] = array[i + 1];
                    removeItem = true;
                }
                else if (removeItem)
                {
                    outcome[i] = array[i + 1];
                }
                else
                {
                    outcome[i] = array[i];
                }
                
            }
            array = outcome;
            return removeItem;
        }

        public IEnumerator GetEnumerator()
        {
            for  (int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }

        public override string ToString()
        {
            string rtn = "";

            for (int i = 0; i < count; i++)
            {
                rtn += array[i];
            }
            return rtn;
        }
    }
}
