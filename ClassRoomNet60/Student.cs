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

        public string Name { get; private set; }
        public int Birth_Month { get; private set; }
        public int Birthday { get; private set; }

        public string Season()
        {
            string season;
            switch (Birth_Month)
            {
                case 1: case 2: case 12: season = "Winter"; break;
                case 3: case 4: case 5: season = "Spring"; break;
                case 6: case 7: case 8: season = "Summer"; break;
                case 9: case 10: case 11: season = "Autumn"; break;
                default: season = ""; break;
            }
            return season;
        }
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Birth_Month)}={Birth_Month.ToString()}, {nameof(Birthday)}={Birthday.ToString()}}}";
        }
    }

    
}
