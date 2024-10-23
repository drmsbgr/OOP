using ConsoleApp.Collections.Heap;
using ConsoleApp.Models;

var heap = new MaxHeap<Student>
{
    new (1, "Alı", 3.2),
    new (2, "Bugra", 1.8),
    new (3, "Mert", 4.0),
    new (4, "Buşra", 3.7),
    new (5, "Azra", 2.2)
};

int n = heap.Count;

for (int i = 0; i < n; i++)
{
    var s = heap.Extract();
    Console.WriteLine($"{s.Number}\t{s.FullName}\t{s.GPA}");
}



// var heap1 = new MaxHeap<int>();
// heap1.Add(20);
// heap1.Add(5);
// heap1.Add(3);
// heap1.Add(2);
// heap1.Add(12);

// var n1 = heap1.Count;
// for (int i = 0; i < n1; i++)
//     Console.WriteLine(heap1.Extract());

// Console.WriteLine();

// var heap2 = new MinHeap<int>();
// heap2.Add(8);
// heap2.Add(3);
// heap2.Add(1);
// heap2.Add(2);
// heap2.Add(5);

// var n2 = heap2.Count;
// for (int i = 0; i < n2; i++)
//     Console.WriteLine(heap2.Extract());

// Console.ReadKey();
