class MainClass
{
    static void Main(string[] args)
    {
        //Array ID = Array.CreateInstance(typeof(int), 3);
        int[] ID = new int[3];
        string[] Name = new string[3];
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

        Console.WriteLine("\nID\tName\t\tAddress\t\t\tState");
       
        for (int i = 0; i < ID.Length; i++)
        {   
            //ID.GetValue(i)
            Console.WriteLine($"{ID[i]}\t{Name[i]}\t\t{Address[i]}\t\t\t{State[i]}");
        }
        Array.Sort(Name);
        Console.WriteLine("\nSap xep ten\n");
        for (int i = 0; i < ID.Length; i++)
        {
            Console.WriteLine($"{Name[i]}");
        }


    }


}