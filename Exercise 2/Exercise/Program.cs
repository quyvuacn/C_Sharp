Console.WriteLine("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= 9; i++)
{
    Console.WriteLine($"{n}*{i}={i*n}");
}
