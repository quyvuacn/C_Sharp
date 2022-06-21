int num = 8;

string name;
Console.WriteLine("Moi ban nhap ten: ");

name = Console.ReadLine();

num = num + 8;
//num = 16
double sqrtNum = Math.Sqrt(num);
Console.WriteLine(sqrtNum);
num++;
Console.WriteLine(num);
num--;
Console.WriteLine(num);
Console.WriteLine(Math.Pow(num,2));


Console.WriteLine(name.ToUpper()); // Viet hoa toan bo
Console.WriteLine(name.IndexOf("uy")); // Tim kiem vi tri cua chuoi con
Console.WriteLine(name[1]); // 
Console.WriteLine(name.Length); // Do dai

