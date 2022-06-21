//Number format

Console.WriteLine("Currency formatting - {0:C} {1:C4}", 88.8, 888.8);
Console.WriteLine("Integer formatting - {0:D5}", 88);
Console.WriteLine("Exponential formatting - {0:E}", 888.8);
Console.WriteLine("Fixed-point formatting - {0:F3}", 888.8888);
Console.WriteLine("General formatting - {0:G}", 888.8888);
Console.WriteLine("Number formatting - {0:N}", 8888888.8);
Console.WriteLine("Hexadecimal formatting - {0:X4}", 88);

//Date format
DateTime dt = DateTime.Now; // obtain current time 
Console.WriteLine("d format: {0:d}", dt);
Console.WriteLine("D format: {0:D}", dt);
Console.WriteLine("t format: {0:t}", dt);
Console.WriteLine("T format: {0:T}", dt);
Console.WriteLine("f format: {0:f}", dt);
Console.WriteLine("F format: {0:F}", dt);
Console.WriteLine("g format: {0:g}", dt);
Console.WriteLine("G format: {0:G}", dt);
Console.WriteLine("m format: {0:m}", dt);
Console.WriteLine("M format: {0:M}", dt);
Console.WriteLine("r format: {0:r}", dt);
Console.WriteLine("R format: {0:R}", dt);
Console.WriteLine("s format: {0:s}", dt);
Console.WriteLine("u format: {0:u}", dt);
Console.WriteLine("U format: {0:U}", dt);
Console.WriteLine("y format: {0:y}", dt);
Console.WriteLine("Y format: {0:Y}", dt);
