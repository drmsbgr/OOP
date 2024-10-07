var numbers = new int[] { 70, 32, 23, 24, 7 };

var myClass = new Mathf(numbers);
Console.WriteLine(myClass);
Console.WriteLine(myClass.name);
Console.WriteLine(myClass.version);

Console.WriteLine("\nDizi Elemanları");

for (int i = 0; i < myClass.numbers.Length; i++)
    Console.WriteLine(myClass.numbers[i]);

Console.WriteLine($"\nEn kucuk eleman: {myClass.GetMin()}");

class Mathf
{
    public string name = "Matematik sınıfı";
    public double version = 1.0;
    public int[] numbers = [98, 78, 13, 43, 2];

    public Mathf(int[] array)
    {
        this.numbers = array;
    }

    public int GetMin()
    {
        var min = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
            if (min > numbers[i])
                min = numbers[i];

        return min;
    }
}