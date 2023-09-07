
class Sum
{
    public void sum1(int A)
    {
        Console.WriteLine($"Элемент {A}");
    }
    public void sum1(int A,int B)
    {
        Console.WriteLine($"Сумма двух чисел {A}+{B}={A+B}");
    }
    public void sum1(int A, int B, int C)
    {
        Console.WriteLine($"Сумма трех чисел {A}+{B}+{C}={A+B+C}");
    }
    public void sum1(int A, int B, int C, int D)
    {
        Console.WriteLine($"Сумма четырех чисел {A}+{B}+{C}+{D}={A+B+C+D}");
    }
    class Test
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            sum.sum1(1, 3);
            sum.sum1(1, 3, 5);
            sum.sum1(1, 3, 5, 9);
            Console.ReadLine();
        }
    }
}




