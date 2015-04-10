//-----------------------------------------------------------------------
// <copyright file="GenericClassMain.cs" company = "Telerik Academy">
// Copyright (c) Telerik Academy. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace _02.GenericClass
    {
    using System;

    public class GenericClassMain
        {
        public static void Main()
            {
            var elements = new GenericList<int>();

            // clearing the generic list
            Console.WriteLine(elements);
            Console.WriteLine("Count: {0}", elements.Count);
            Console.WriteLine("Capacity: {0}", elements.Capacity);

            // the auto-grow
            elements = new GenericList<int>(3);
            elements.Add(1);
            elements.Add(2);
            elements.Add(3);
            elements.Add(4);

            Console.WriteLine(Environment.NewLine + elements);
            Console.WriteLine("Count: {0}", elements.Count);
            Console.WriteLine("Capacity: {0}", elements.Capacity);

            // inserting and removing elemenents
            elements.Clear();

            elements.Insert(0, 4);
            elements.Insert(0, 3);
            elements.Insert(0, 2);
            elements.Insert(0, 1);

            elements.RemoveAt(0);
            elements.RemoveAt(elements.Count - 1);

            Console.WriteLine(Environment.NewLine + elements);
            Console.WriteLine("Elements count: {0}", elements.Count);
            Console.WriteLine("Capacity of the list: {0}", elements.Capacity);

            // accessing element by index; finding element by its value;
            Console.WriteLine(Environment.NewLine + "Contain element 2: {0}", elements.Contains(2));
            Console.WriteLine("Index of element 3 {0}", elements.IndexOf(3));

            // Finding minimum and maximum elements
            Console.WriteLine(Environment.NewLine + "Min element: {0}", elements.Min());
            Console.WriteLine("Max element: {0}", elements.Max());
            }
        }
    }
