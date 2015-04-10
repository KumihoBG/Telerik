using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{  
    /*
     Problem 7. Min and Max

Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
You may need to add a generic constraints for the type T.
    */
    public static class MinAndMaxMethods
    {
        public static T Min<T>(this GenericList<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentNullException("The list is empty");
            }
            dynamic min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                } 
            }
            return (T)min;
        }

        public static T Max<T>(this GenericList<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentNullException("The list is empty");
            }
            dynamic max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return (T)max;
        } 
    }
}
