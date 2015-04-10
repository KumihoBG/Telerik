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
    public class GenericClassTests
    {
        public static void Main(string[] args)
        {
            var arr = new GenericList<int>();
            arr.AddElement(1);
            arr.AddElement(9);
            arr.AddElement(2);
            arr.AddElement(6);
            arr.AddElement(8);
            Console.WriteLine("Sequence of elements");
            Console.WriteLine(string.Join("", arr));
            Console.WriteLine("Element at index 3 is {0}", arr[3]);

            arr.RemoveElementAtIndex(3);
            Console.WriteLine("After removing of element at index 3");
            Console.WriteLine(string.Join("", arr));

            arr.InsertElementAtIndex(2, 5);
            Console.WriteLine("After inserting of element at index 2");
            Console.WriteLine(string.Join("", arr));
            arr.ClearList();
            Console.WriteLine("After clearing of all elements: count of elements = {0}", arr.Count);
            Console.WriteLine("New sequence of elements");
            arr.AddElement(11);
            arr.AddElement(7);
            arr.AddElement(3);
            arr.AddElement(6);
            arr.AddElement(4);
            Console.WriteLine(string.Join("", arr));
            Console.Write("Index of element 4 in new collection: ");
            Console.WriteLine(arr.FindElementIndex(4));
            Console.WriteLine("Minimal value is {0}", arr.Min());
            Console.WriteLine("Maximal value is {0}", arr.Max());

        }
    }
}
