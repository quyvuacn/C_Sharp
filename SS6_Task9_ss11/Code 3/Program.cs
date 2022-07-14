//Generic Class

class Student
{
    int id;
    string name;
    

    public Student(int ID, string name)
    {
        this.id = ID;
        this.name = name;
    }

    public string Name
    {
        get { return name; }
    }
    public int ID 
    { 
        get { return id; }
    }
}

class GenericList<S> where S : Student
{
    S[] _stu = new S[3];
    int _counter = 0;
    public void Add(S val)
    {
        _stu[_counter++] = val;
    }
    public void Display()
    {
        for (int i = 0; i < _stu.Length; i++)
        {
            Console.WriteLine(_stu[i].ID+"."+_stu[i].Name);
        }
    }
}

class Demo
{
    static void Main(string[] args)
    {
        GenericList<Student> list = new GenericList<Student>();
        list.Add(new Student(1, "Vu Viet Quy"));
        list.Add(new Student(2, "Nguyen Dac Dung"));
        list.Add(new Student(3, "Ta Duy Linh"));
        list.Display();
    }
}
