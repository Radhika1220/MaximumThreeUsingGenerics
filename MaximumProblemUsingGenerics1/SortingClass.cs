using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_UnitTesting
{
    public class SortingClass<T> where T : IComparable
    {
        public T[] arrayList;
        public SortingClass(T[] arrayList)
        {
            this.arrayList = arrayList;
        }
        public T[] Sort(T[] arrayList)
        {
            Array.Sort(arrayList);
            return arrayList;
        }
        public T MaximumValueFunction(T[] arrayList)
        {
            var sortarrayval = Sort(arrayList);
            return sortarrayval[arrayList.Length-1];
        }
        public T MaxMethod()
        {
            T maxValue = this.MaximumValueFunction(arrayList);
            return maxValue;
        }

    }
}
