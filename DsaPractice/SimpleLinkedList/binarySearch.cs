using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DsaPractice.SimpleLinkedList
{
    public class binarySearch
    {
        public int binaryS(int[] arr, int key)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == key)
                    return mid;
                else if (arr[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}