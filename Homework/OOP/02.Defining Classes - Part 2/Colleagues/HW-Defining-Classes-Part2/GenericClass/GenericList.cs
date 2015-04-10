using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    /*
     Problem 5. Generic class

Write a generic class GenericList<T> that keeps a
list of elements of some parametric type T.
Keep the elements of the list in an array with fixed capacity 
which is given as parameter in the class constructor.
Implement methods for adding element, accessing element by index,
removing element by index, inserting element at given position, 
clearing the list, finding element by its value and ToString().
Check all input parameters to avoid accessing elements at invalid positions.
    */
    public class GenericList<T>
    {
        private const int DefaultCapacity = 32;
        private T[] elements;
        private int count;
        private int capacity;

        public int Count
        {
            get { return this.count; }
        }

        // Constructors
        public GenericList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("The capacity must be positive.");
            }
            else
            {
                this.elements = new T[capacity];
                this.count = 0;
                this.capacity = capacity;
            }
        }

        public GenericList()
            : this(DefaultCapacity)
        { }

        //Accessing element by index
        // Indexer
        public T this[int index]
        {
            get
            {
                if (IsInRange(index))
                {
                    return this.elements[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }
            }
            set
            {
                if (IsInRange(index))
                {
                    this.elements[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }
            }
        }

        private bool IsInRange(int index)
        {
            if (index < 0 || index >= this.count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Add element to the list
        public void AddElement(T element)
        {
            if (this.count >= this.capacity)
            {
                Grow();
            }
            this.elements[this.count] = element;
            this.count++;
        }

        /*6.Implement auto-grow functionality: when the internal array is full, 
        create a new array of double size and move all elements to it.*/
        private void Grow()
        {
            T[] tempList = new T[this.capacity];
            this.elements.CopyTo(tempList, 0);
            this.capacity *= 2;
            this.elements = new T[this.capacity];
            tempList.CopyTo(this.elements, 0);
        }

          // Remove element at given position
        public void RemoveElementAtIndex(int index)
        {
            if (IsInRange(index))
            {
                // default keyword  return null for reference types and zero for numeric value types.
                T nextElement = default(T);
                for (int i = index; i < this.elements.Length - 1; i++)
                {
                    nextElement = this.elements[i + 1];
                    this.elements[i] = nextElement;
                }
                this.count--;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }

        // Insert element at given position
        public void InsertElementAtIndex(int index, T element)
        {
            if (IsInRange(index))
            {
                if (this.count >= this.capacity)
                {
                    Grow();
                }
                for (int i = this.count; i >= index; i--)
                {
                    this.elements[i] = this.elements[((i - 1) >= 0) ? (i - 1) : 0];
                }
                this.elements[index] = element;
                this.count++;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }

        // Clearing the list
        public void ClearList()
        {
             this.elements = new T[this.capacity];
             this.count = 0;
        }

        // Find element by it's value
        public int FindElementIndex(T searchedValue)
        {
            return Array.IndexOf(this.elements, searchedValue);
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                return "Empty list!";
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.count; i++)
            {
                if (i == count - 1)
                {
                   builder.Append(String.Format("{0}", this.elements[i])); 
                }
                else
                {
                    builder.Append(String.Format("{0}, ", this.elements[i]));
                }
            }
            return builder.ToString();
        }
    }
}
