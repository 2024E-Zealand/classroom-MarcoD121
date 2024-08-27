using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public Student(string name, int birth_Month, int birthday)
        {
            Name = name;
            Birth_Month = birth_Month;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public int Birth_Month { get; set; }
        public int Birthday { get; set; }

    }

    
}
