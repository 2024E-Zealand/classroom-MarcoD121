using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        string Class_Room {  get; set; }
        List<Student> StudentList { get; set; }
        DateTime Semester_Start { get; set; }

        public ClassRoom()
        {
            
        }
    }
}
