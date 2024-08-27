using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string Class_Room {  get; set; }
        public List<Student> StudentList { get; set; }
        public DateTime Semester_Start { get; set; }

        public ClassRoom()
        {
            StudentList = new List<Student>();
        }
    }
}
