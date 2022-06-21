int num = 50;
bool isTrue = (1>2);
string name = "vu viet quy";

bool isBigNum = num > 100 ? true : false;


Console.WriteLine($"1>2 is : {isTrue}");
Console.WriteLine($"num={num} is bignum : {isBigNum}");
if(name == "vu viet quy")
{
    Console.WriteLine($"Xin chao {name}");
}else if(name == "Nguyen Dac Dung")
{
    Console.WriteLine("Hi!,{0}","Dung");
}
else
{
    Console.WriteLine("Hello! How are you?");
}

switch (name)
{
    case "vu viet quy":
        Console.WriteLine(name);
        break;
    default:
        Console.WriteLine("Hi");
        break;
}

