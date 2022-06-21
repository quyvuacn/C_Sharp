using System;

namespace People
{
    class Student
    {
        public int roolNo;
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        //Constructor
        public Student(int roolNo, string name)
        {
            this.roolNo=roolNo;
            this.name=name;
        }
        public Student()
        {
            this.roolNo = 0;
            this.name = null;
        }

         


    }
}