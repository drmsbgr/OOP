using ConsoleApp;
using ConsoleApp.Entities;
using ConsoleApp.Heaps;

var heap = new MaxHeap<Product>();
heap.Add(new Product(1, "laptop", 32_000));
heap.Add(new Product(2, "phone", 13_000));
heap.Add(new Product(3, "e-guitar&amp", 24_000));
HeapManager.ExtractAll(heap);