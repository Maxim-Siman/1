namespace _1;

class Plant
{
    public string Name;
    public int Height, Weight;
    
    public Plant(string Name, int Height)
    {
        this.Name = Name;
        this.Height = Height;
        this.Weight = 0;
    }
    public Plant(string Name, int Height, int Weight)
    {
        this.Name = Name;
        this.Height = Height;
        this.Weight = Weight;
    }

    class Test2
    {
        static void Main(string[] args)
        {
            Plant plant1 = new Plant(Name:"Boris",Height:35);
            Console.WriteLine("plant1 : {0}, {1}",plant1.Name,plant1.Height);
            Plant plant2 = new Plant(Name:"Boris",Height:35,Weight:6);
            Console.WriteLine("plant1 : {0}, {1}, {2}",plant2.Name,plant2.Height,plant2.Weight);
            Console.ReadLine();
        }
    }
}