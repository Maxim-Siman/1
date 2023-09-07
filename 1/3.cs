using System;

namespace _1;

class Index
{ 
    int[] arr;
    public int Length;

    public Index(int Size)
    {
        arr = new int [Size];
        Length = Size;
    }

    public int this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }
    public int this[double index]
    {
        get { return arr[(int)index]; }
        set { arr[(int)index] = value; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Index newarr = new Index(10);
            newarr[5.5] = 45;
            newarr[6.3] = 34;
            newarr[7.6] = 4;
            newarr[8.9] = 3;
            newarr[9.3] = 8;
            Console.WriteLine("Последний получвшийся массив: ");
            for (int i = 5; i <= 10; ++i)
            {
                Console.WriteLine($"newarr[{i}] = {newarr[i]}");
            }
        }
    }

}