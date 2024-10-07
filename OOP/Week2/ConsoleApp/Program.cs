// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

var numbers = new int[] { 10, 20, 5, 3, 2, 1 };

static int GetMin(int[] array)
{
    var min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
    }

    Console.WriteLine(min);
    return min;
}

GetMin(numbers);
