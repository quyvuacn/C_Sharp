using System;
using System.Collections.Generic;
//General Class
class General<T> // <T> : General Type. Co the thay T bang A,B,C,...
{
    T[] values;
    int _counter = 0;
    public General(int max)    {
        values=new T[max];
    }
    public void Add(T val)
    {
        if (_counter<values.Length)
        {
            values[_counter++] = val;
        }
    }

    public void Display()
    {
        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine(values[i]);
        }
    }
}


class Students{
    static void Main()
    {
        General<string> objGeneral = new General<string>(3);
        objGeneral.Add("Quy");
        objGeneral.Add("Linh");
        objGeneral.Add("Dung");
        objGeneral.Display();
        General<int> objInt = new General<int>(2);
        objInt.Add(1);
        objInt.Add(2);
        objInt.Display();
    }
}