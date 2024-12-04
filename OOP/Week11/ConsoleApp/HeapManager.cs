using ConsoleApp.Interfaces;

namespace ConsoleApp;

public static class HeapManager
{
    public static void ExtractAll<T>(IHeap<T> heap) where T : IComparable<T>
    {
        while (heap.Count > 0)
            Console.WriteLine(heap.Extract());
    }
}