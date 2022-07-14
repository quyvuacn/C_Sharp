using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

class ReadOnly
{
    static void Main(string[] args)
    {
        List<string> objList = new List<string>();
        objList.Add("Quy");
        objList.Add("Linh");
        objList.Add("Dung");
        ReadOnlyCollection<string> objReadOnly = new ReadOnlyCollection<string>(objList);
        Console.WriteLine("Ok");
        foreach (string obj in objReadOnly)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine();
        Console.WriteLine("So phan tu: {0}",objList.Count);
        if (objList.Contains("Quy"))
        {
            objList.Insert(2, "Quan");
        }
        foreach (string obj in objReadOnly)
        {
            Console.WriteLine(obj);
        }
        string[] array = new string[objList.Count*2];
        
        objList.CopyTo(array,2 );//Sao chep mang objList sang array bat dau voi index=2 cua objList

        Console.WriteLine("Size cua mang arr :{0}",array.Length);
        Console.WriteLine("New arr");
        foreach(string str in array)
        {
            if (str==null)
            {
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine(str);
            }
            
        }
    }
}
