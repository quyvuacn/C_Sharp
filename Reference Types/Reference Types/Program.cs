class MainClass
{
    static void Main(string[] args)
    {
        int[] ID = new int[3];
        string[] Name = new string[3] ;
        string[] Address = new string[3];
        string[] State = new string[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nhap ID");
            ID[i] = Convert.ToInt32(Console.ReadLine());
            // ID.SetValue(value,index)
            Console.WriteLine("Nhap ten");
            Name[i] = Console.ReadLine();
            Console.WriteLine("Nhap dia chi");
            Address[i] = Console.ReadLine();
            Console.WriteLine("Nhap State");
            State[i] = Console.ReadLine();
        }

        Console.WriteLine("ID\tName\t\tAddress\t\t\tState");
        for (int i = 0; i < ID.Length; i++)
        {
            Console.WriteLine($"{ID[i]}\t{Name[i]}\t\t{Address[i]}\t\t\t{State[i]}");
        }
        Array.Sort(Name);
        for (int i = 0; i < ID.Length; i++)
        {
            Console.WriteLine($"{Name[i]}");
        }


    }

} 