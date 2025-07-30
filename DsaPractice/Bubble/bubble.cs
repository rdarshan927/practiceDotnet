using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DsaPractice.Bubble
{
    public class Bubble
    {
        public int[] bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
            return arr;
        }

        public int[] selectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                (arr[i], arr[min]) = (arr[min], arr[i]);
            }
            return arr;
        }

        public int[] mergeSort2(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                mergeSort2(arr, left, mid);
                mergeSort2(arr, mid + 1, right);
                merge2(arr, left, mid, right);
            }
            return arr;
        }

        public void merge2(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[mid + 1 + j];

            int inLeft = 0, inRight = 0;
            int k = left;

            while (inLeft < n1 && inRight < n2)
            {
                if (leftArray[inLeft] <= rightArray[inRight])
                    arr[k++] = leftArray[inLeft++];
                else
                    arr[k++] = rightArray[inRight++];
            }

            while (inLeft < n1)
                arr[k++] = leftArray[inLeft++];
            while (inRight < n2)
                arr[k++] = rightArray[inRight++];
        }


        public void merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[mid + 1 + j];

            int leftIn = 0, rightIn = 0;
            int key = left;

            while (leftIn < n1 && rightIn < n2)
            {
                if (leftArray[leftIn] < rightArray[rightIn])
                    arr[key++] = leftArray[leftIn++];
                else
                    arr[key++] = rightArray[rightIn++];
            }

            while (leftIn < n1)
                arr[key++] = leftArray[leftIn++];
            while (rightIn < n2)
                arr[key++] = rightArray[rightIn++];
        }
        public int[] mergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                mergeSort(arr, left, mid);
                mergeSort(arr, mid + 1, right);
                merge(arr, left, mid, right);
            }
            return arr;
        }

        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }
        public int[] quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
            return arr;
        }
    }
}