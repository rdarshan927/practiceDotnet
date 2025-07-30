// See https://aka.ms/new-console-template for more information
using DsaPractice.Bubble;
using DsaPractice.SimpleLinkedList;
using DsaPractice.Stack;

Console.WriteLine("Hello, World!");

int[] arr = [1, 5, 6, 3, 2, 9, 0, 2];
Bubble bSort = new Bubble();
// arr = bSort.bubbleSort(arr);
// arr = bSort.selectionSort(arr);
// bSort.mergeSort(arr, 0, arr.Length - 1);
// bSort.quickSort(arr, 0, arr.Length - 1);
Stack s = new Stack(5);
// Console.WriteLine(string.Join(", ", arr));
// s.push(1);
// s.push(6);
// s.push(3);
// s.push(2);
// Console.WriteLine($"Hello, {s.pop()}");
// Console.WriteLine($"Hello, {s.peek()}");
Queue q = new Queue(6);
// q.Enqueue(1);
// q.Enqueue(3);
// q.Enqueue(4);
// q.Enqueue(9);
// q.Enqueue(8);
// Console.WriteLine($"removed - {q.Dequeue()}");
// Console.WriteLine($"removed - {q.Dequeue()}");
// q.Enqueue(1);
// q.Enqueue(3);
// q.Display();
// s.display();
// Console.WriteLine(string.Join(", ", arr));
// Array.Sort(arr);
// Console.WriteLine(string.Join(", ", arr));
binarySearch b = new binarySearch();
// Console.WriteLine(b.binaryS(arr, 4));
Dictionary<int, int> freq = new Dictionary<int, int>();

foreach (int item in arr)
{
    if (freq.ContainsKey(item))
        freq[item]++;
    else
        freq[item] = 1;
}

foreach (var num in freq)
{
    Console.WriteLine($"{num.Key} occurs {num.Value} times");
}