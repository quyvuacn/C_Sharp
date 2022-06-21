static int sum(int num1,int num2)
{
    return num1 + num2;
}

static void Hello(string name)
{
    Console.WriteLine($"Hello {name}");
}

Hello("Quy");
Console.WriteLine(sum(2,4));

//Out Parameters

int num1,num2,num3;

static void getThreeNum(out int num1,out int num2,out int num3)
{
    num1 = 1;
    num2 = 2;
    num3 = 3;
}

getThreeNum(out num1,out num2,out num3);
Console.WriteLine($"num1={num1},num2={num2},num3={num3}");

//Lambda Expressions => tuong tu callback js

int[] numbers = { 3, 10, 4, 6, 8 };
static bool isTen(int n)
{
    return n == 10;
}
Array.Exists(numbers, isTen);

Array.Exists(numbers, (int n) => {
    return n == 10;
});
Array.Find(numbers, (int n) => { return n != 7; });

Array.Find(numbers, (n) => { return n != 7; });

Array.Find(numbers, n => { return n != 7; });

Array.Find(numbers, n => n != 7);



