static int max(int num1,int num2,int num3)
{
    int max = num1;
    if (num2>max)
    {
        max = num2;
    }
    if (num3>max)
    {
        max = num3;
    }
    return max;
}

static int ReadInt()
{
    return Convert.ToInt32(Console.ReadLine());
}

int num1, num2, num3;
Console.WriteLine("Moi ban nhap so thu nhat: ");
num1 = ReadInt();
Console.WriteLine("Moi ban nhap so thu hai: ");
num2 = ReadInt();
Console.WriteLine("Moi ban nhap so thu ba: ");
num3 = ReadInt();
Console.WriteLine($"So lon nhat la: {max(num1,num2,num3)}");