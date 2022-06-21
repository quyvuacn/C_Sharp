//Khai bao
int[] numbers = { 3, 14, 59 };
string[] names = new string[3] { "Quy", "Linh", "Dung" };


Console.WriteLine(numbers[1]);
Console.WriteLine(names[0]);
Console.WriteLine(numbers.Length);

int size = numbers.Length;

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

foreach(string name in names)
{
    Console.WriteLine($"Xin chao {name}");
}

while (size-->0)
{
    Console.WriteLine(numbers[size]);
}