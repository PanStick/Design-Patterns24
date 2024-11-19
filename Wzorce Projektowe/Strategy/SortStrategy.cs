using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Strategy
{

    static class Context
    {
        public static ISortStrategy GetContext(int[] item)
        {
            if (item.Length < 10)
                return new BubbleSort();
            if(item.Length < 100)
                return new InsertionSort();
            return new Quicksort();
        }
    }
    interface ISortStrategy
    {
        int[] Sort(int[] item);
    }

    class Quicksort : ISortStrategy
    {
        int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);
            if (i < rightIndex)
                SortArray(array, i, rightIndex);
            return array;
        }
        public int[] Sort(int[] item)
        {
            return SortArray(item, 0, item.Length);
        }
    }
    class BubbleSort : ISortStrategy
    {
        public int[] Sort(int[] item)
        {
            var n = item.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (item[j] > item[j + 1])
                    {
                        var tempVar = item[j];
                        item[j] = item[j + 1];
                        item[j + 1] = tempVar;
                    }
            return item;
        }
    }

    class InsertionSort : ISortStrategy
    {
        public int[] Sort(int[] item)
        {
            for (int i = 1; i < item.Length; i++)
            {
                var key = item[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < item[j])
                    {
                        item[j + 1] = item[j];
                        j--;
                        item[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
            return item;
        }
    }


}
