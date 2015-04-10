//-----------------------------------------------------------------------
// <copyright file="GenericClass.cs" company = "Telerik Academy">
// Copyright (c) Telerik Academy. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace _02.GenericClass
    {
    using System;
    using System.Linq;
    using System.Text;

    public class GenericList<T>
        {
        // Fields of the class
        private const int Counting = 1;

        private T[] elements;

        // Constructs a generic list
        public GenericList(int capacity = Counting)
            {
            this.Count = 0;
            this.Capacity = capacity;
            this.elements = new T[capacity];
            }

        // Properties of the class
        public int Count { get; private set; }

        public int Capacity { get; private set; }

        public T this[int index]
            {
            get
                {
                if (index >= 0 && index < this.elements.Length)
                    {
                    return this.elements[index];
                    }
                else
                    {
                    throw new IndexOutOfRangeException("Invalid index.");
                    }
                }

            set
                {
                if (index >= 0 && index < this.elements.Length)
                    {
                    this.elements[index] = value;
                    }
                else
                    {
                    throw new IndexOutOfRangeException("Invalid index.");
                    }
                }
            }

        // adding element
        public void Add(T item)
            {
            this.Count++;
            this.Resize(this.Count);
            this.elements[this.Count - 1] = item;
            }

        // inserting element at given position
        public void Insert(int index, T item)
            {
            if (index < 0 || index > this.elements.Length)
                {
                throw new IndexOutOfRangeException("Invalid index.");
                }

            this.Count++;
            this.Resize(this.Count);
            Array.Copy(this.elements, index, this.elements, index + 1, this.Count - index - 1);
            this.elements[index] = item;
            }

        // removing element by index
        public void RemoveAt(int index)
            {
            if (index < 0 || index > this.elements.Length)
                {
                throw new IndexOutOfRangeException("Invalid index.");
                }

            this.Count--;
            this.Resize(this.Count);
            Array.Copy(this.elements, index + 1, this.elements, index, this.Count - index);
            this.elements[index] = default(T);
            }

        // accessing element by index
        public int IndexOf(T item)
            {
            return Array.IndexOf(this.elements, item);
            }

        // finding element by its value
        public bool Contains(T item)
            {
            return this.elements.Contains(item);
            }

        // clearing the list
        public void Clear()
            {
            this.Count = 0;
            this.Capacity = Counting;
            this.elements = new T[this.Capacity];
            }

        // To string
        public override string ToString()
            {
            if (this.Count == 0)
                {
                return "Empty list!";
                }

            var result = new StringBuilder();
            result.Append("Element(s): ");
            for (int i = 0; i < this.Count; i++)
                {
                result.AppendFormat("{0}", this.elements[i]);
                if (i + 1 < this.Count)
                    {
                    result.Append(", ");
                    }
                }

            return result.ToString();
            }

        // finding the minimal and maximal element in the GenericList<T>
        public T Min()
            {
            T minValue = this.elements[0];
            for (int i = 0; i < this.elements.Length; i++)
                {
                if (this.minValue > (dynamic)this.elements[i])
                    {
                    this.minValue = this.elements[i];
                    }
                }

            return minValue;
            }

        public T Max()
            {
            T maxValue = this.elements[0];
            for (int i = 0; i < this.elements.Length; i++)
                {
                if (maxValue < (dynamic)this.elements[i])
                    {
                    maxValue = this.elements[i];
                    }
                }

            return maxValue;
            }

        // Auto-grow
        private void Resize(int capacity)
            {
            this.Capacity = 2 * capacity;
            Array.Resize(ref this.elements, this.Capacity);
            }
        }
    }