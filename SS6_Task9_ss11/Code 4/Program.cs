//generic method

class SwapNumber
{
    static void Swap<Num>(ref Num num1,ref Num num2)
    {
        Num temp = num1;
        num1 = num2;
        num2 = temp;
    }

    static void Main(string[] args)
    {
        int num1 = 20;
        int num2 = 25;
        Console.WriteLine("num1={0} / num2={1}", num1, num2);
        Swap(ref num1,ref num2);
        Console.WriteLine("Swap");
        Console.WriteLine("num1={0} / num2={1}", num1, num2);
    }
}